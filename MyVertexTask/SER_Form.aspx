<%@ Page Title="SER_Form" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SER_Form.aspx.cs" Inherits="MyVertexTask.SER_FORM" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main class="p-4 m-auto border-1" style="width:720px">
        <section id="header" class="d-flex flex-column w-100">
            <div class="d-flex flex-row justify-content-between align-items-center">
                <asp:Image ID="Image1" runat="server" AlternateText="Logo" BackColor="#99CCFF" Height="42px" ImageUrl="https://res.cloudinary.com/drixwe3ie/image/upload/v1682522091/Picture1mfdkfadsjkdfsk_q67let.png" Width="172px" />
                <div class="fw-bolder" style="font-size:25px; font-family: 'Times New Roman', Times, serif;">
                    <span style="font-size:28px">S</span>TUDENT <span style="font-size:30px">E</span>LIGIBILITY <span style="font-size:30px">F</span>ORM
                </div>
                <div class="text-end">
                    <div class="fw-bold" style="font-size:20px; font-family: 'times New Roman', Times, serif;"><span style="font-size:26px">F</span>ORM <span style="font-size:26px">1</span></div>
                    <div class="fw-bold" style="font-size:12px; font-family: 'times New Roman', Times, serif;"><span style="font-size:18px">S</span>IDE <span style="font-size:18px">1</span></div>
                </div>
            </div>
            <div class=" text-center fst-italic">
               Please type or print neatly
           </div>
        </section>

        <section id="content" class="mx-4 my-1" style="font-family: 'times New Roman', Times, serif; font-size: 14px;">
            <div class="d-flex flex-row justify-content-between align-items-center">
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox1" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="195px"></asp:TextBox>
                    <div>Your Present College</div>
                </div>
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox2" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="150px"></asp:TextBox>
                    <div>Your Present Conference</div>
                </div>
                <div class="d-flex flex-column align-items-center">
                     <asp:DropDownList ID="DropDownList1" runat="server" Width="119px" Height="27px" style="border: solid 2px red">
                        <asp:ListItem Value="">Choose</asp:ListItem>
                        <asp:ListItem Value="Football">Football </asp:ListItem>  
                        <asp:ListItem Value="Basketball">Basketball</asp:ListItem>  
                        <asp:ListItem Value="Track and Field">Track and Field</asp:ListItem>  
                        <asp:ListItem Value="Volleyball">Volleyball</asp:ListItem>  
                    </asp:DropDownList>
                    <div>Sport This Season</div>
                </div>
                <div class="d-flex flex-column align-items-center">
                    <div style="width: 120px" class="text-center">
                        Previous Seasons of Competition Used in This Sports
                    </div>
                    <div>
                        0 <asp:RadioButton ID="RadioButton1" GroupName="PreviousSeasonsOptions" runat="server"/> or 1
                        <asp:RadioButton ID="RadioButton2" GroupName="PreviousSeasonsOptions" runat="server"/>
                        <%--<asp:RequiredFieldValidator ID="OptionsValidator" runat="server" ControlToValidate="RadioButton1" ErrorMessage="Please select an option." Display="Dynamic" />--%>
                    </div>
                </div>
            </div>

            <div class="d-flex flex-row justify-content-between align-items-center">
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox3" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="290px"></asp:TextBox>
                    <div>Last Name, First, MI</div>
                </div>
                <div>
                    <asp:RadioButton ID="RadioButton3" runat="server"/> Male <br />
                    <asp:RadioButton ID="RadioButton4" runat="server" /> Female
                </div>
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox4" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="120px"></asp:TextBox>
                    <div>Student ID#</div>
                </div>
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox5" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="120px"></asp:TextBox>
                    <div style="margin-right: -30px">Today's Date (mm/dd/yy)</div>
                </div>
            </div>

            <div class="d-flex flex-row justify-content-between align-items-center">
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox6" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="360px"></asp:TextBox>
                    <div>Present Address, Street, City, State and ZipCode</div>
                </div>
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox7" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="120px"></asp:TextBox>
                    <div>Telephone #</div>
                </div>
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox8" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="120px"></asp:TextBox>
                    <div style="margin-right: -30px">Date of Birth (mm/dd/yy)</div>
                </div>
            </div>

            <div class="d-flex flex-row justify-content-between align-items-center">
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox9" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="490px"></asp:TextBox>
                    <div>High School Last Attended, City, State and ZipCode</div>
                </div>
                <div class="d-flex flex-column align-items-center">
                    <asp:TextBox ID="TextBox10" runat="server" BorderColor="Red" BorderStyle="Solid" BorderWidth="2px" Width="120px"></asp:TextBox>
                    <div style="margin-right: -55px">Last Date Attended (mm/dd/yy)</div>
                </div>
            </div>

            <div class="mt-4">
                Accurately account for all your time <span class="fst-italic">high school graduation and the present</span>. Beginning with the year you left high school, 
                list employment dates, period of unemployment, armed forces service, and all educational institution in which you have registered, 
                including your present college. <span class="fst-italic">Do </span>include summer school. <span class="fst-italic">Do not </span>include summer <span>jobs.</span>
            </div>

            <div>
                <table>
                    <thead class="text-center" >
                        <tr>
                            <th colspan="2" style="border: 1px solid black">From
                                <table>
                                    <tr>
                                        <th style="width:56px; border: 1px solid black">Mo</th>
                                        <th style="width:55px; border: 1px solid black">Yr</th>
                                    </tr>
                                </table>
                            </th>
                            <th colspan="2" style="border: 1px solid black">To
                                <table>
                                    <tr>
                                        <th style="width:61px; border: 1px solid black">Mo</th>
                                        <th style="width:61px; border: 1px solid black">Yr</th>
                                    </tr>
                                </table>
                            </th>
                            <th style="width:400px; border: 1px solid black">Colleges Attended or Jobs Held, City, State</th>
                        </tr>
                        <tr>
                            <th><asp:TextBox ID="FromMo1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="56px"></asp:TextBox></th>
                            <th><asp:TextBox ID="FromYr1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="55px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToMo1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToYr1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="CollegesJobs1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="400px" style="margin-left:-1px"></asp:TextBox></th>
                        </tr>
                        <tr>
                            <th><asp:TextBox ID="FromMo2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="56px"></asp:TextBox></th>
                            <th><asp:TextBox ID="FromYr2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="55px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToMo2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToYr2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="CollegesJobs2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="400px" style="margin-left:-1px"></asp:TextBox></th>
                        </tr>
                        <tr>
                            <th><asp:TextBox ID="FromMo3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="56px"></asp:TextBox></th>
                            <th><asp:TextBox ID="FromYr3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="55px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToMo3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToYr3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="CollegesJobs3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="400px" style="margin-left:-1px"></asp:TextBox></th>
                        </tr>
                        <tr>
                            <th><asp:TextBox ID="FromMo4" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="56px"></asp:TextBox></th>
                            <th><asp:TextBox ID="FromYr4" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="55px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToMo4" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToYr4" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="CollegesJobs4" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="400px" style="margin-left:-1px"></asp:TextBox></th>
                        </tr>
                        <tr>
                            <th><asp:TextBox ID="FromMo5" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="56px"></asp:TextBox></th>
                            <th><asp:TextBox ID="FromYr5" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="55px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToMo5" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="ToYr5" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="61px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="CollegesJobs5" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="400px" style="margin-left:-1px"></asp:TextBox></th>
                        </tr>
                       
                    </thead>
                    
                </table>
            </div>

            <div>
                Including this college and this season, list all the colleges and sports in which you have <span class="fst-italic">practiced, scrimmaged, or competed, </span>including 
                <span class="fst-italic">club sports, JV, and varsity contests </span>since high school: (If you only practices or scrimmaged in a sport, please state.)
            </div>
            <div>

                <table>
                    <thead class="text-center" >
                        <tr>
                            <th style="width:150px; border: 1px solid black">Sport</th>
                            <th style="width:250px; border: 1px solid black">College</th>
                            <th style="width:95px; border: 1px solid black">VarsityJV/Club</th>
                            <th style="width:85px; border: 1px solid black">Semester</th>
                            <th style="width:55px; border: 1px solid black">Yr</th>
                        </tr>
                        <tr>
                            <th><asp:TextBox ID="Sport1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="150px"></asp:TextBox></th>
                            <th><asp:TextBox ID="College1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="250px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Varsity1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="95px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Semester1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="85px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Yr1" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="55px" style="margin-left:-1px"></asp:TextBox></th>
                        </tr>
                        <tr>
                            <th><asp:TextBox ID="Sport2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="150px"></asp:TextBox></th>
                            <th><asp:TextBox ID="College2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="250px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Varsity2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="95px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Semester2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="85px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Yr2" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="55px" style="margin-left:-1px"></asp:TextBox></th>
                        </tr>
                        <tr>
                            <th><asp:TextBox ID="Sport3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="150px"></asp:TextBox></th>
                            <th><asp:TextBox ID="College3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="250px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Varsity3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="95px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Semester3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="85px" style="margin-left:-1px"></asp:TextBox></th>
                            <th><asp:TextBox ID="Yr3" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" Width="55px" style="margin-left:-1px"></asp:TextBox></th>
                        </tr>
                    </thead>
                </table>
            </div>

            <div class="mt-3 text-center fs-5 fw-bold">
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Submit_Onclick" Width="200px" Height="40px" BorderWidth="10px" CssClass="fw-bold border border-secondary" style="border-radius:15px" />
            </div>
        </section>
    </main>
    
</asp:Content>