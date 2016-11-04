<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="ContactUs" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title>Contact Us</title>
   </head>
   <body style="width: 989px; margin-left: 212px; margin-top: 84px">
      <form id="form1" runat="server">
         <div>
            <table>
               <tr>
                  <td>
                     <h3> Contact Us  </h3>
                  </td>
               </tr>
               <tr>
                  <td><b>Name</b></td>
                  <td>
                     <asp:TextBox ID="txtName" runat="server" Width="210px"></asp:TextBox>
                  </td>
                  <td>
                     <asp:RequiredFieldValidator
                        Display="Dynamic"
                        ForeColor="Red"
                        ID="rvfName"
                        ControlToValidate="txtName"
                        runat="server"
                        ErrorMessage="* Name is Required" />
                  </td>
               </tr>
               <tr>
                  <td><b>Email:</b></td>
                  <td>
                     <asp:TextBox ID="txtEmail" runat="server" Width="214px" />
                  </td>
                  <td>
                     <asp:RequiredFieldValidator
                        Display="Dynamic"
                        ForeColor="Red"
                        ID="RequiredFieldValidator2"
                        runat="server"
                        ControlToValidate="txtEmail"
                        ErrorMessage="* Email is required" />
                     <asp:RegularExpressionValidator ID="rvxEmail"
                        ControlToValidate="txtEmail" runat="server"
                        ErrorMessage="* Invalid email"
                        ForeColor="Red"
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                  </td>
               </tr>
               <tr>
                  <td>
                     <b>Message:</b>
                  </td>
                  <td>
                     <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="10" Width="340px" Height="46px" />
                  </td>
                  <td>
                     <asp:RequiredFieldValidator ID="rvfMessage"
                        ControlToValidate="txtMessage"
                        runat="server" ForeColor="Red"
                        ErrorMessage="* Message Mandatory" />
                  </td>
               </tr>
               <tr>
                  <td>
                     <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
                  </td>
               </tr>
               <tr>
                  <td>
                     <asp:Label ID="lblMesaage" runat="server" />
                  </td>
               </tr>
            </table>
         </div>
      </form>
   </body>
</html>