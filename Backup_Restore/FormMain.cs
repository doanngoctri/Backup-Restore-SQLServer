using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Backup_Restore
{


    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        int bansaoluu;
        String tendevice;
        int vitri=0;
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dS.backup_devices' table. You can move, or remove it, as needed.
            //this.backup_devicesTableAdapter.Fill(this.dS.backup_devices);
            // TODO: This line of code loads data into the 'dS.databases' table. You can move, or remove it, as needed.
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Fill(this.dS.backup_devices);

            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.dS.databases);
            //gcST_STT_BACKUP.Enabackup_devicesTableAdapterbled = false;
            bdsDatabases.Position = 0;
            label1.Visible = !label1.Visible;
            txtthongbao.Visible = !txtthongbao.Visible;
            dateStop.Visible = !dateStop.Visible;
            timeStop.Visible = !timeStop.Visible;
            gcDatabases_Click(sender, e);

        }

     

        private void LoadCacBanSaoLuu()
        {
            
            if (txtTenDB.Text.Trim() == "") return;
            try
            {
                this.sT_STT_BACKUPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sT_STT_BACKUPTableAdapter.Fill(this.dS.ST_STT_BACKUP, txtTenDB.Text);
                this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
                this.backup_devicesTableAdapter.Fill(this.dS.backup_devices);
                /*                btnRestore.Enabled = true;
                                Delete1.Enabled = true;*/
                /*                if (bdsST_STT_BACKUP.Count == 0)
                                {
                                    btnRestore.Enabled = false;
                                    //Delete1.Enabled = false;

                                }*/
                CheckDeviceExist();
                if (bdsST_STT_BACKUP.Count > 0)
                {
                    btnRestore.Enabled = true;
                    btnDeleteO.Enabled = true;
                    Delete1.Enabled = true;
                    bansaoluu = int.Parse(((DataRowView)bdsST_STT_BACKUP[0])["position"].ToString());
                    
                }
                else
                {
                    btnRestore.Enabled = false;
                    btnDeleteO.Enabled = false;
                    Delete1.Enabled = false;
                    bansaoluu = 0;
                }
                txtbansaoluu.Text = bansaoluu.ToString();
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sT_STT_BACKUPTableAdapter.Fill(this.dS.ST_STT_BACKUP, txtTenDB.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát!", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                //Program.form.Show();
            }
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String StrBackup ,StrName;
            if (txtTenDB.Text.Trim() == "" || tendevice == "") return;
            //CheckDeviceExist();
            StrBackup = "BACKUP DATABASE " + txtTenDB.Text.Trim() + " TO " + tendevice;
            if (chkInit.Checked == true)
                if (MessageBox.Show("Bạn thật sự muốn xóa các bản sao lưu cũ.", " Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    StrBackup = StrBackup + " WITH INIT";
                else
                    return;
            //ham program ExecSqlNonquery
            int err = Program.ExecSqlNonQuery(StrBackup, Program.connstr, "");
            if (err != 0)
            {
                MessageBox.Show("Lỗi backup cơ sở dữ liệu" + txtTenDB.Text);
                return;
            }
            MessageBox.Show("Đã Backup cơ sở dữ liệu");
            
            LoadCacBanSaoLuu();

        }

        private void gcST_STT_BACKUP_Click(object sender, EventArgs e)
        {
            if (bdsST_STT_BACKUP.Position == -1 || bdsST_STT_BACKUP.Count == 0 || gcST_STT_BACKUP.DataSource == null) bansaoluu = 0;
            else bansaoluu = int.Parse(((DataRowView)bdsST_STT_BACKUP[bdsST_STT_BACKUP.Position])["position"].ToString());
            txtbansaoluu.Text = bansaoluu.ToString();
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int err;
            if (this.bdsST_STT_BACKUP.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (bansaoluu == 0)
            {
                MessageBox.Show("Chưa có 1 bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();//đóng kết nối

            if (txtTenDB.Text.Trim() == "" || tendevice == "") return;
            if (btnNangcao.Checked == false)
            {

                String strRestore = " ALTER DATABASE " + txtTenDB.Text.Trim()
                    + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                    " USE tempdb RESTORE DATABASE " + txtTenDB.Text.Trim()
                    + " FROM   " + tendevice + " WITH FILE =  " + bansaoluu + ", REPLACE  "
                    + " ALTER DATABASE  " + txtTenDB.Text.Trim() + " SET MULTI_USER";


                if (MessageBox.Show("Bạn chắc chắc muốn phục hồi database ", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi");
                    if (err == 0)
                        MessageBox.Show("Phục hồi thành công", "", MessageBoxButtons.OK);
                }
                else
                    return;

            }


            else
            {
                
                DateTime ngaygiobk = (DateTime)((DataRowView)bdsST_STT_BACKUP[0])["backup_start_date"];
                string strThoiDiemStopAt = dateStop.DateTime.Year + "-" + dateStop.DateTime.Month + "-" + dateStop.DateTime.Day + " " +
                    timeStop.Time.Hour + ":" + (timeStop.Time.Minute) + ":" + timeStop.Time.Second;
                Console.Write(((DataRowView)bdsST_STT_BACKUP[0])["position"].ToString());
                DateTime ThoiDiemStopAt;
                ThoiDiemStopAt = DateTime.Parse(strThoiDiemStopAt);
                if ((dateStop.DateTime.Date < ngaygiobk.Date) ||
                           (dateStop.DateTime.Date == ngaygiobk.Date && ThoiDiemStopAt.TimeOfDay.Ticks < ngaygiobk.TimeOfDay.Ticks))
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải sau bản sao luu đã chọn.", "", MessageBoxButtons.OK);
                    return;
                }
                if (ThoiDiemStopAt > DateTime.Now)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                    return;
                }
                if ((MessageBox.Show("Bạn chắc chắn muốn phục hồi database " + txtTenDB.Text + " về ngày " +
                    ThoiDiemStopAt + " ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK))
                {
                    String month = dateStop.DateTime.Month < 10 ? "0" + dateStop.DateTime.Month : dateStop.DateTime.Month.ToString();
                    String day = dateStop.DateTime.Day < 10 ? "0" + dateStop.DateTime.Day : dateStop.DateTime.Day.ToString();
                    String hour = timeStop.Time.Hour < 10 ? "0" + timeStop.Time.Hour : timeStop.Time.Hour.ToString();
                    String minute = timeStop.Time.Minute < 10 ? "0" + timeStop.Time.Minute : timeStop.Time.Minute.ToString();
                    String second = timeStop.Time.Second < 10 ? "0" + timeStop.Time.Second : timeStop.Time.Second.ToString();
                    String CheckTime = dateStop.DateTime.Year + "/" + month + "/" + day + " " +
                    hour + ":" + minute + ":" + second;
                    String StrTendevice = "use "+ txtTenDB.Text.Trim()+ 
                        "\nselect  [Begin Time]  from  fn_dblog(null,null)"+
                        "where[Begin Time] < '"+ CheckTime + "'";
                    Program.myreader = Program.ExecSqlDataReader(StrTendevice);
                    if (Program.myreader == null) return;
                    Program.myreader.Read();

                    //có device thì ẩn btn newdevice
                    if (!Program.myreader.Read())
                    {
                        MessageBox.Show("Không tìm thấy bản log trong lịch sử.", "", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            //restore về thời điểm người dùng nhập
                            String strRestore = "ALTER DATABASE " + txtTenDB.Text.Trim() + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n" +
                                " BACKUP LOG " + txtTenDB.Text + " TO DISK ='" + Program.strDefaultPath + "/" + "DEVICE_DB" +
                                txtTenDB.Text.Trim() + ".trn' WITH INIT, NORECOVERY; \n" + " USE tempdb \n " +
                                " RESTORE DATABASE " + txtTenDB.Text.Trim() + " FROM DEVICE_DB" + txtTenDB.Text.Trim() + " WITH FILE = " + ((DataRowView)bdsST_STT_BACKUP[0])["position"].ToString() + ",NORECOVERY; \n" +
                                " RESTORE DATABASE " + txtTenDB.Text.Trim() + " FROM DISK= '" + Program.strDefaultPath + "/" + "DEVICE_DB" + txtTenDB.Text.Trim() + ".trn' " +
                                " WITH STOPAT= '" + strThoiDiemStopAt + "' \n" +
                                " ALTER DATABASE  " + txtTenDB.Text.Trim() + " SET MULTI_USER ";
                            //MessageBox.Show(strRestore);
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi csdl.");
                            if (err == 0)
                            {
                                MessageBox.Show("Phục hồi cơ sở dữ liệu đến "+ strThoiDiemStopAt +" thành công!", "", MessageBoxButtons.OK);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi Restore:\n" + ex +"\n Tự động phục hồi về bản sao lưu mới nhất!", "", MessageBoxButtons.OK);
                            String strRestore = " ALTER DATABASE " + txtTenDB.Text.Trim()
                            + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                            " USE tempdb RESTORE DATABASE " + txtTenDB.Text.Trim()
                            + " FROM   " + tendevice + " WITH FILE =  " + ((DataRowView)bdsST_STT_BACKUP[0])["position"].ToString() + ", REPLACE  "
                            + " ALTER DATABASE  " + txtTenDB.Text.Trim() + " SET MULTI_USER";
                            err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "Lỗi phục hồi");
                            if (err == 0)
                                MessageBox.Show("Phục hồi thành công", "", MessageBoxButtons.OK);

                        }
                    }
                    
                }
                else return;
            }
        }

        private void btnNangcao_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            label1.Visible = !label1.Visible;
            txtthongbao.Visible = !txtthongbao.Visible;
            dateStop.Visible = !dateStop.Visible;
            timeStop.Visible = !timeStop.Visible;
            dateStop.DateTime = DateTime.Now;
            timeStop.Time = DateTime.Now;
        }

        private void btnNewdevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tendevice = "DEVICE_DB" + txtTenDB.Text;
            String strFullPathDevice = Program.strDefaultPath + "/" + tendevice;

            String query = "USE master\n EXEC sp_addumpdevice '" + Program.device_type + "', '" + tendevice + "','" + strFullPathDevice + "'";
            try
            {

                Program.myreader = Program.ExecSqlDataReader(query);
                if (Program.myreader != null)
                {
                    MessageBox.Show(" Tạo Device thành công!", "", MessageBoxButtons.OK);
                    this.backup_devicesTableAdapter.Fill(this.dS.backup_devices);
                    btnNewdevice.Enabled = false;
                    btnSave.Enabled = true;

                }
                else MessageBox.Show(" Tạo Device thất bại!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                return;
            }

            Program.conn.Close();



        }

        private void HideNewdevice()
        {
            btnSave.Enabled = btnRestore.Enabled = btnNangcao.Enabled = true;
            btnNewdevice.Enabled =  false;
        }
        private void ShowDevice()
        {
            btnSave.Enabled = btnRestore.Enabled = btnNangcao.Enabled = false;
            btnNewdevice.Enabled = true;
        }
        public int Delete(int id)
        {
            using (SqlConnection connetion = new SqlConnection(Program.connstr))
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM sys.backup_devices WHERE position = @Id;", connetion))
                {
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    connetion.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
        public int DeleteByName(String name)
        {
            using (SqlConnection connetion = new SqlConnection(Program.connstr))
            {
                using (SqlCommand command = new SqlCommand("EXEC sp_dropdevice @name, 'delfile' ; ", connetion))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    connetion.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int DeleteHistory(String name)
        {
            using (SqlConnection connetion = new SqlConnection(Program.connstr))
            {
                using (SqlCommand command = new SqlCommand("EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = @name", connetion))
                {
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    connetion.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public int DeleteOlderThan(String time)
        {
            using (SqlConnection connetion = new SqlConnection(Program.connstr))
            {
                using (SqlCommand command = new SqlCommand("EXEC sp_delete_backuphistory @oldest_date = @time;", connetion))
                {
                    command.Parameters.Add("@tine", SqlDbType.NVarChar).Value = time;
                    connetion.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
        private void CheckDeviceExist()
        {
            String StrTendevice = "select  COUNT(name)  from  sys.backup_devices  WHERE  name  =  N'Device_DB" +
                txtTenDB.Text.Trim() + "'";
            Program.myreader = Program.ExecSqlDataReader(StrTendevice);
            if (Program.myreader == null) return;
            Program.myreader.Read();

            //có device thì ẩn btn newdevice
            if (Program.myreader.GetInt32(0) > 0)
            {
                HideNewdevice();
                tendevice = "DEVICE_DB" + txtTenDB.Text.Trim();

            }
            // chưa có device chỉ hiện newdevice vs thoát
            else ShowDevice();
            Program.myreader.Close();

        }


        private void gcDatabases_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (bdsDatabases.Position == -1 || bdsDatabases.Count == 0 || bdsDatabases.DataSource == null)
                    txtTenDB.Text = "";
                else txtTenDB.Text = ((DataRowView)bdsDatabases[bdsDatabases.Position])["name"].ToString();
                LoadCacBanSaoLuu();
                txtTenDB.Text = gvData.GetRowCellValue(gvData.FocusedRowHandle, "name").ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK);
            }
           
        }

        //delete a device
        private void btnDeleteO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa toàn bộ đĩa không ", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            try
            {
                tendevice = "DEVICE_DB" + txtTenDB.Text;
                DeleteByName(tendevice);
                DeleteHistory(txtTenDB.Text);

                LoadCacBanSaoLuu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "Question", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //delete one
        public string GenScript(string dbname, int vtri)
        {
            string str = "DECLARE @database_name NVARCHAR(100)," +
                " @VTRI INT SET @VTRI = " + vtri + " SET @database_name = '" + dbname + "' " +
                "DECLARE @backup_set_id INT DECLARE @media_set_id INT DECLARE @restore_history_id TABLE (restore_history_id INT) SELECT @backup_set_id = MIN(backup_set_id) FROM msdb.dbo.backupset WHERE database_name = @database_name AND type = 'D' AND backup_set_id >= (SELECT MAX(backup_set_id) FROM msdb.dbo.backupset WHERE media_set_id = (SELECT MAX(media_set_id) FROM msdb.dbo.backupset WHERE database_name = @database_name AND type='D') AND position = @VTRI) SELECT @media_set_id = media_set_id FROM msdb.dbo.backupset WHERE backup_set_id = @backup_set_id INSERT INTO @restore_history_id (restore_history_id) SELECT DISTINCT restore_history_id FROM msdb.dbo.restorehistory WHERE backup_set_id = @backup_set_id SET XACT_ABORT ON BEGIN TRANSACTION BEGIN TRY DELETE FROM msdb.dbo.backupfile WHERE backup_set_id = @backup_set_id DELETE FROM msdb.dbo.backupfilegroup WHERE backup_set_id = @backup_set_id DELETE FROM msdb.dbo.restorefile WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id) DELETE FROM msdb.dbo.restorefilegroup WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id) DELETE FROM msdb.dbo.restorehistory WHERE restore_history_id IN (SELECT restore_history_id FROM @restore_history_id) DELETE FROM msdb.dbo.backupset WHERE backup_set_id = @backup_set_id COMMIT TRANSACTION END TRY BEGIN CATCH ROLLBACK DECLARE @ErrMess VARCHAR(1000) SELECT @ErrMess = 'LOI: ' + ERROR_MESSAGE() RAISERROR(@ErrMess, 16, 1) END CATCH";
            return str;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa bản này không ", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                return;
            if (bansaoluu == 1)
            {
                if (MessageBox.Show("Nếu Xóa bản backup đầu tiên thì sẽ mất các bản backup còn lại!!! ", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
            }
            String sql = GenScript(txtTenDB.Text,bansaoluu);
            
            try
            {
                int err = Program.ExecSqlNonQuery(sql, Program.connstr, "Lỗi phục hồi");
                if (err == 0)
                {
                    MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
                    LoadCacBanSaoLuu();
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex, "Question", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //refresh
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Fill(this.dS.backup_devices);

            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.dS.databases);
            bdsDatabases.Position = 0;
        }
    }
}