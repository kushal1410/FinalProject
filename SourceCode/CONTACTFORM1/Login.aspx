<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title>Login Page</title>
     <script type="text/javascript">
         function VerifyData()
         {
             if (document.getElementById('txtUSERNAME').value == "" || document.getElementById('txtPASSWORD').value == "")
             {
                 alert("Please enter both UserName and Password");
                 return false;
             }
             return true;
         }
     </script>
   </head>
   <body style="width: 557px; margin-left: 245px; margin-top: 118px">
      <form id="form1" style="margin:0 auto" runat="server">
         <div>
            <table style="align-content: center">
               <tr>
                  <td>
                     <h2><b>Login Page</b></h2>
                  </td>
               </tr>
               <tr>
                  <td><b>USERNAME</b></td>
                  <td>
                     <asp:TextBox ID="txtUSERNAME" runat="server"></asp:TextBox>
                  </td>                  
               </tr>
               <tr>
                  <td>
                     <b>PASSWORD</b>
                  </td>
                  <td>
                     <asp:TextBox ID="txtPASSWORD" TextMode="PASSWORD" runat="server" />
                  </td>
               </tr>
               <tr>
                  <td>
                     <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" OnClientClick="return VerifyData();" />
                  </td>
               </tr>
               <tr>
                  <td>
                     <asp:Label ID="lblMessage2" runat="server" />
                  </td>
               </tr>
               <tr>
                  <td>
                     <asp:Label ID="lblMessage3" runat="server" />
                  </td>
               </tr>
            </table>
            <%--<table style="align-content:center">
               <tr>
                   <td> <h3>Integrating twilio message</h3></td>
               
                  
                   <td>
                       
                      <b> To Number</b>
                       <asp:TextBox ID="txtToNumber" runat="server" />
               
                   </td>
               
                 
               </tr>
               
               
               <tr>
                   <td>
                       <b>SMS Message</b>
                   </td>
                   <td>
               
                       <asp:TextBox ID="Message" Onclick="" runat="server" />
                   </td>
               
               </tr>
               <tr>
                   <td>
                       <asp:Button ID="SendMessage" runat="server" Text="Send Message" OnClick="SendMessage_Click" />
               
               
                   </td>
               </tr>
               
               </table>--%>
         </div>
      </form>
   </body>
</html>