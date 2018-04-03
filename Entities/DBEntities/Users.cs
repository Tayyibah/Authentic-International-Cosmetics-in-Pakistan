using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.DBEntities
{

    [Table("dbo.UsersTable")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
       public String Email { get; set; }
        public Boolean IsActive { get; set; }
        public int UsersType { get; set; }
        public int MappingId { get; set; }
        public String PictureName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        //[NotMapped]
        //public List<ApprDesigDTO> ApprDesignations
        //{
        //    get;
        //    set;
        //}
    }
    [Table("dbo.Products")]
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public String Name { get; set; }
        public String PictureName { get; set; }
        public Boolean isActive { get; set; }
        public int Price { get; set; }

        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        
    }
    [Table("dbo.[addToCart]")]
    public class addToCart
    {
        [Key]
        public int cartID  { get; set; }
        public int ProductID  { get; set; }
        public int UserID { get; set; }
    }
    [Table("dbo.Bill_To")]
    public class Bill_To
    {
        [Key]
        public int BillNo { get; set; }
        public int UserID { get; set; }
        public int Total { get; set; }
        public String Country { get; set; }
        public String Zip { get; set; }
        public String Address_2 { get; set; }
        public String Address_1 { get; set; }
        public String Last_Name { get; set; }
        public String Middle_Name { get; set; }
        public int First_Name { get; set; }
        public String Title { get; set; }
        public String Email { get; set; }
        public String Company_Name { get; set; }
        public int confirm_password { get; set; }
        public String Password { get; set; }
        public String User_Name { get; set; }
        public String Display_Name { get; set; }



        public String State { get; set; }
        public String Phone1 { get; set; }
        public int Phone2 { get; set; }
        public String Mobile_Phone { get; set; }
        public String Fax { get; set; }
        public String message { get; set; }
        public String Shipping { get; set; }
    }
      
    [Table("dbo.Comments")]
    public class Comments
    {
        [Key]
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public String CommentText { get; set; }
        public DateTime CommentOn { get; set; }
        public String UserName { get; set; }
        public String PictureName { get; set; }
    }
    [Table("dbo.MappingsTable")]
    public class MappingsTable
    {
        [Key]
        public int ProductID { get; set; }
        public int UserId { get; set; }
        public int MappingId { get; set; }
        public Boolean AddToCart { get; set; }
        public DateTime Date { get; set; }
    }
    [Table("dbo.feedback")]
    public class feedback
    {
        [Key]
        public int Feedback_no { get; set; }
        public String message { get; set; }
        public String email { get; set; }
    }
    [Table("dbo.contact_us")]
    public class contact_us
    {
        [Key]
        public int Contact_Id { get; set; }
        public String message { get; set; }
        public String subject { get; set; }
        public String name { get; set; }
        public String email { get; set; }
    }

    public class Approver
    {
        public int ApproverID { get; set; }
        public String Login { get; set; }
        public String Name { get; set; }
        public String Designation { get; set; }
        public String Email { get; set; }

        public int WorkFlowStatus { get; set; }
    }
    [Table("dbo.reply_form")]
    public class reply_form
    {
        public String name { get; set; }
        public String email { get; set; }
        public String website { get; set; }
        public String message { get; set; }
        
    }
    
    //public class UserDTOForAutoComplete
    //{
    //    public int UserId { get; set; }
    //    public String Login { get; set; }
    //    public String Name { get; set; }
    //}
    //public class LoginHistorySearchParam
    //{
    //    public LoginHistorySearchParam()
    //    {
    //        SDate = new DateTime(1900, 1, 1);
    //        EDate = DateTime.MaxValue;
    //        Login = "";
    //        MachineIp = "";
    //        PageSize = 10;
    //        PageIndex = 0;
    //    }
    //    public String Login { get; set; }
    //    public String MachineIp { get; set; }
    //    public DateTime SDate { get; set; }
    //    public DateTime EDate { get; set; }
    //    public int PageSize { get; set; }
    //    public int PageIndex { get; set; }
    //}
    //public class AppStatusesSearchParam
    //{
    //    public AppStatusesSearchParam()
    //    {

    //        Login = "";
    //        IsApprover = 0;
    //        Status = 0;
    //    }
    //    public String Login { get; set; }
    //    public int IsApprover { get; set; }
    //    public int Status { get; set; }
    //}
    //public class UserSearchParam
    //{
    //    public String TextToSearch { get; set; }
    //    public int IsActive { get; set; }
    //    public int IsContributor { get; set; }
    //    public int IsOldCampus { get; set; }
    //    public int PageSize { get; set; }
    //    public int PageIndex { get; set; }
    //}

    //public class UserSearchResultObj
    //{
    //    public int UserId { get; set; }
    //    public String Login { get; set; }
    //    public String Name { get; set; }
    //    public String Title { get; set; }
    //    public String Email { get; set; }
    //    public Boolean IsActive { get; set; }
    //    public String SignatureName { get; set; }
    //    public String StdFatherName { get; set; }
    //    public String Section { get; set; }
    //    public Boolean IsContributor { get; set; }
    //    public Boolean IsOldCampus { get; set; }

    //    [NotMapped]
    //    public String IsContributorStr
    //    {
    //        get
    //        {
    //            return (this.IsContributor == true ? "Yes" : "No");

    //        }
    //    }

    //}

    //public class UserSearchResult
    //{
    //    public int ResultCount { get; set; }
    //    public List<UserSearchResultObj> Result { get; set; }
    //}
    //public class LoginHistorySearchResult
    //{
    //    public int ResultCount { get; set; }
    //    public List<LoginHistory> Result { get; set; }
    //}
}
