Imports System.Reflection

Class MainWindow

    Dim ExperienceItems As New List(Of ExperienceItem)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ExperienceItems.Add(New ExperienceItem With {
            .Title = "Firmware Design & Development",
            .Experiences = New List(Of String) From {
                  "Firmware development using C/C++ and Visual Studio.",
                  "Initialization and configuration of microcontrollers and peripherals.",
                  "Development and integration of drivers for communication interfaces and peripherals, including Displays and Bluetooth, among others.",
                  "Participation in the design, implementation, and maintenance of embedded systems."
                  },
            .ImagePath = "Images\Firmware.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
            .Title = "Embedded Solutions Testing & Validation - GenIO Tester",
            .Experiences = New List(Of String) From {
                  "GenIOTester - Designed and developed an automated validation system capable of diagnosing embedded hardware and software.",
                  "Mapped and tested digital and analog I/O, as well as communication protocols including CAN Bus, Ethernet, RS-232, RS-485, Bluetooth, RFID, and USB.",
                  "Implemented XML-based test configuration, allowing automated execution of complete validation sequences (with GenIO Tester).",
                  "Developed validation procedures and release checklists for multiple products."
                  },
            .ImagePath = "Images\GenIO.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
            .Title = "Final product validation - EV Charger",
            .Experiences = New List(Of String) From {
                  "Responsible for validating firmware and hardware releases before deployment.",
                  "Mapped and tested digital and analog I/O, as well as communication protocols including CAN Bus, Ethernet, RS-232, RS-485, Bluetooth, RFID, and USB.",
                  "Tested multiple charger configurations, including single-phase and three-phase installations, public and private operation modes, Bluetooth and RFID authentication, scheduling features, load balancing, and multi-charger installations.",
                  "Automated test with GenIO Tester"
                  },
            .ImagePath = "Images\EVCharger.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
            .Title = "Software Debugging",
            .Experiences = New List(Of String) From {
                  "Debugging using breakpoints, logs, CLI outputs, conditional debugging code, and diagnostic tools.",
                  "Investigation of software-hardware interactions, including LED indicators, communication failures, and timing issues.",
                  "Root cause analysis of firmware and system-level issues."
                  },
            .ImagePath = "Images\Degugging.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
        .Title = "Hardware Debugging & Diagnostics - Altium",
        .Experiences = New List(Of String) From {
              "Reading and understanding Altium schematics for troubleshooting and analysis.",
              "Signal and communication debugging using oscilloscopes.",
              "Electrical measurements and I/O diagnostics using digital multimeters.",
              "Hardware investigation, repair, modification, and validation of electronic boards."
              },
        .ImagePath = "Images\HardwareDb.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
        .Title = "Programming Languages",
        .Experiences = New List(Of String) From {
              "C (Strong)",
              "C# (Strong)",
              "C++ (Strong)",
              "Visual Basic .NET (Strong)",
              "Python (Strong)",
              "SQL (Strong)",
              "XML",
              "HTML",
              "Assembler"
              },
        .ImagePath = "Images\PLang.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
        .Title = "Hardware and Software Migration",
        .Experiences = New List(Of String) From {
            "Supported migration projects caused by component shortages and hardware revisions.",
            "Adapted firmware to support multiple hardware versions simultaneously.",
            "Assisted in driver migration and validation of new microcontroller platforms."
            },
        .ImagePath = "Images\Migration.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
        .Title = "Microcontrollers & Embedded Interfaces",
        .Experiences = New List(Of String) From {
            "Experience configuring and developing applications using GPIO, UART, USART, SPI, and I2C interfaces.",
            "Experience with STM32 and Atmel microcontrollers.",
            "Familiarity with RTOS-based environments.",
            "Comfortable reading datasheets, technical manuals, and component documentation to implement new functionality."
            },
        .ImagePath = "Images\Microcontrollers.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
        .Title = "Documentation",
        .Experiences = New List(Of String) From {
            "Responsible for technical documentation across multiple projects.",
            "Development of user manuals, validation procedures, lifecycle documentation, and technical reports.",
            "Experience documenting cybersecurity policies, procedures, and compliance requirements.",
            "FUN FACT! Used LaTeX throughout university projects and my Bachelor's Thesi"
            },
        .ImagePath = "Images\Documentation.png"
        })
        ExperienceItems.Add(New ExperienceItem With {
        .Title = "Version Control & Collaboratio",
        .Experiences = New List(Of String) From {
            "Experience using Git and GitHub in both academic and professional environments.",
            "Daily use of collaborative development workflows, including commits, branching, merging, and version control practices.",
            "Experience working with multidisciplinary teams and external clients in shared codebases."
            },
        .ImagePath = "Images\Git.png"
        })
        'lstDemoOutput.ItemsSource = ExperienceItems

    End Sub

    Private Sub ListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

    End Sub

    Private Sub Hyperlink_RequestNavigate(sender As Object, e As RequestNavigateEventArgs)

        Process.Start(New ProcessStartInfo(e.Uri.AbsoluteUri) With {
                .UseShellExecute = True
            })

        e.Handled = True

    End Sub

    Private Sub Open_Why(sender As Object, e As RoutedEventArgs)
        Try
            Dim Win_popup As New Why()
            Win_popup.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening 'Why do I want to work at FliteBoard': " & ex.Message)
        End Try
    End Sub

    Private Sub Open_WhatIBring(sender As Object, e As RoutedEventArgs)
        Try
            Dim Win_popup As New WhatIBring()
            Win_popup.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening 'Pros and Cons of hiring me': " & ex.Message)
        End Try
    End Sub

    Private Sub Open_WorkExperience(sender As Object, e As RoutedEventArgs)
        Try
            Dim Win_popup As New Experience()
            Win_popup.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening 'Work Experience': " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Try
            Dim index As Integer = ComboBox_experience.SelectedIndex

            If index >= 0 Then

                lstDemoOutput.ItemsSource = Nothing

                lstDemoOutput.ItemsSource =
            New List(Of ExperienceItem) From {
                ExperienceItems(index)
            }

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Open_PInfo(sender As Object, e As RoutedEventArgs)
        Try
            Dim Win_popup As New PInfo()
            Win_popup.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening 'Personal Info': " & ex.Message)
        End Try
    End Sub

    Private Sub Open_Education(sender As Object, e As RoutedEventArgs)
        Try
            Dim Win_popup As New Education()
            Win_popup.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening 'Pros and Cons of hiring me': " & ex.Message)
        End Try
    End Sub

    Private Sub Open_Thesis(sender As Object, e As RoutedEventArgs)
        Try
            Dim Win_popup As New Thesis()
            Win_popup.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening 'Pros and Cons of hiring me': " & ex.Message)
        End Try
    End Sub

    Private Sub lstDemoOutput_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles lstDemoOutput.SelectionChanged

    End Sub
End Class
