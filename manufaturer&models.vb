

Private Sub UserForm_Initialize()

With ComboBox1
    .AddItem "Aerco"
    .AddItem "Camus"
    .AddItem "Cleaver Brooks"
    .AddItem "Fulton"
    .AddItem "Laars"
    .AddItem "Lochinvar"
    .AddItem "Patterson-Kelley"
    .AddItem "PVI"
    .AddItem "RBI"
    .AddItem "Riello"
End With

End Sub
Private Sub ComboBox1_Change()

Dim index As Integer
index = ComboBox1.ListIndex

ComboBox2.Clear

Select Case index
'Aerco
    Case Is = 0
        With ComboBox2
            .AddItem "AM 399"
            .AddItem "AM 500"
            .AddItem "AM 750"
            .AddItem "AM1000"
            .AddItem "BMK-750"
            .AddItem "BMK-1000"
            .AddItem "BMK-1500"
            .AddItem "BMK-2000"
            .AddItem "BMK-2500"
            .AddItem "BMK-3000"
            .AddItem "BMK-5000"
            .AddItem "BMK-6000"
            .AddItem "Innovation 600"
            .AddItem "Innovation 800"
            .AddItem "Innovation 1060"
            .AddItem "Innovation 1350"
            .AddItem "Multi-Fuel Condensing 3000"
            .AddItem "Multi-Fuel Condensing 4000"
            .AddItem "Multi-Fuel Condensing 5000"
            .AddItem "Multi-Fuel Condensing 6000"
            .AddItem "Multi-Fuel Condensing 8000"
            .AddItem "Multi-Fuel Condensing 10000"
            .AddItem "Modulex-303"
            .AddItem "Modulex-454"
            .AddItem "Modulex-606"
            .AddItem "Modulex-757"
            .AddItem "Modulex-909"
            .AddItem "Modulex-1060"
            .AddItem "Modulex-EXT-321"
            .AddItem "Modulex-EXT-481"
            .AddItem "Modulex-EXT-641"
            .AddItem "Modulex-EXT-802"
            .AddItem "Modulex-EXT-962"
            .AddItem "Modulex-EXT-1123"
            .AddItem "Modulex-EXT-1500/1530"
            .AddItem "Modulex-EXT-1912"
            .AddItem "Modulex-EXT-2295/2300"
            .AddItem "Modulex-EXT-2600/2677"
            .AddItem "Modulex-EXT-3000/3060"
        End With
        
'Camus
    Case Is = 1
        With ComboBox2
            .AddItem "Dynaforce DR(H)-0300"
            .AddItem "Dynaforce DR(H)-0350"
            .AddItem "Dynaforce DR(H)-0400"
            .AddItem "Dynaforce DR(H)-0500"
            .AddItem "Dynaforce DR(H)-0600"
            .AddItem "Dynaforce DR(H)-0800"
            .AddItem "Dynaforce DR(H)-1000"
            .AddItem "Dynaforce DR(H)-1200"
            .AddItem "Dynaforce DR(H)-1400"
            .AddItem "Dynaforce DR(H)-1600"
            .AddItem "Dynaforce DR(H)-1800"
            .AddItem "Dynaforce DR(H)-2000"
            .AddItem "Dynaforce DR(H)-2500"
            .AddItem "Dynaforce DR(H)-3000"
            .AddItem "Dynaforce DR(H)-3500"
            .AddItem "Dynaforce DR(H)-4000"
            .AddItem "Dynaforce DR(H)-4500"
            .AddItem "Dynaforce DR(H)-5000"

        End With
        
'Cleaver Brooks
    Case Is = 2
        With ComboBox2
            .AddItem "CFLC-4000"
            .AddItem "CFLC-5000"
            .AddItem "CFLC-6000"
            .AddItem "CFLC-8000"
            .AddItem "CFLC-10000"
            .AddItem "CFLC-12000"
            
            .AddItem "CFCE-500"
            .AddItem "CFCE-1000"
            .AddItem "CFCE-1500"
            .AddItem "CFCE-2000"
            .AddItem "CFCE-3500"
            .AddItem "CFCE-4000"
            .AddItem "CFCE-5000"
            .AddItem "CFCE-6000"
            
            .AddItem "CBLE-125"
            .AddItem "CBLE-150"
            .AddItem "CBLE-200"
            .AddItem "CBLE-250"
            .AddItem "CBLE-300"
            .AddItem "CBLE-350"
            .AddItem "CBLE-400"
            .AddItem "CBLE-500"
            .AddItem "CBLE-600"
            .AddItem "CBLE-700"
            .AddItem "CBLE-800"
            
            .AddItem "CBEX-100"
            .AddItem "CBEX-125"
            .AddItem "CBEX-150"
            .AddItem "CBEX-200"
            .AddItem "CBEX-250"
            .AddItem "CBEX-300"
            .AddItem "CBEX-350"
            .AddItem "CBEX-400"
            .AddItem "CBEX-500"
            .AddItem "CBEX-600"
            .AddItem "CBEX-700"
            .AddItem "CBEX-800"
            .AddItem "CBEX-900"
            .AddItem "CBEX-1000"
            .AddItem "CBEX-1100"
            .AddItem "CBEX-1200"

            
            
            
        End With
'Fulton
    Case Is = 3
        With ComboBox2
            .AddItem "EDR-750"
            .AddItem "EDR-1000"
            .AddItem "EDR-1500"
            .AddItem "EDR-2000"
            .AddItem "EDR+2500"
            .AddItem "EDR+3000"
            .AddItem "EDR+6000"
            .AddItem "PHW-0750"
            .AddItem "PHW-1000"
            .AddItem "PHW-2000"
            .AddItem "VTG-2000"
            .AddItem "VTG-3000"
            .AddItem "VTG-4000"
            .AddItem "VTG-5000"
            .AddItem "VTG-6000"
            .AddItem "VMP-40"
            .AddItem "VMP-49.5"
            .AddItem "VMP-50"
            .AddItem "VMP-60"
            .AddItem "VMP-80"
            .AddItem "VMP-100"
            .AddItem "VMP-130"
            .AddItem "VMP-150"
            .AddItem "VSRT-10"
            .AddItem "VSRT-15"
            .AddItem "VSRT-20"
            .AddItem "VSRT-30"
            .AddItem "VSRT-40"
            .AddItem "VSRT-50"
            .AddItem "VSRT-60"
            
        End With
'Laars
    Case Is = 4
        With ComboBox2
            .AddItem "Pennant 500"
            .AddItem "Pennant 750"
            .AddItem "Pennant 1000"
            .AddItem "Pennant 1250"
            .AddItem "Pennant 1500"
            .AddItem "Pennant 1750"
            .AddItem "Pennant PNCH 2000"
            .AddItem "Pennant PNCV 2000"
            .AddItem "MagnaTherm MGH 1600"
            .AddItem "MagnaTherm MGH 2000"
            .AddItem "MagnaTherm MGH 2500"
            .AddItem "MagnaTherm MGH 3000"
            .AddItem "MagnaTherm MGH 3500"
            .AddItem "MagnaTherm MGH 4000"
            .AddItem "MagnaTherm MGV 1600"
            .AddItem "MagnaTherm MGV 2000"
            .AddItem "MagnaTherm MGV 2500"
            .AddItem "MagnaTherm MGV 3000"
            .AddItem "MagnaTherm MGV 3500"
            .AddItem "MagnaTherm MGV 4000"

            
            
        End With
'Lochinvar
    Case Is = 5
        With ComboBox2
            .AddItem "AWH-1250"
            .AddItem "AWH-1500"
            .AddItem "AWH-2000"
            .AddItem "AWH-3000"
            .AddItem "AWH-4000"
            .AddItem "Crest FBN-0751"
            .AddItem "Crest FBN-1001"
            .AddItem "Crest FBN-1251"
            .AddItem "Crest FBN-1501"
            .AddItem "Crest FBN-1751"
            .AddItem "Crest FBN-2001"
            .AddItem "Crest FBN-2500"
            .AddItem "Crest FBN-3000"
            .AddItem "Crest FBN-3500"
            .AddItem "Crest FBN-4000"
            .AddItem "Crest FBN-5000"
            .AddItem "Crest FBN-6000"
            
        End With
'Patterson-Kelley
    Case Is = 6
        With ComboBox2
            .AddItem "Mach CM-300"
            .AddItem "Mach CM-399"
            .AddItem "Mach CM-500"
            .AddItem "Mach C-300"
            .AddItem "Mach C-450"
            .AddItem "Mach C-750"
            .AddItem "Mach C-900"
            .AddItem "Mach C-1050"
            .AddItem "Mach C-1500"
            .AddItem "Mach C-1500H"
            .AddItem "Mach C-2000"
            .AddItem "Mach C-2000H"
            .AddItem "Mach C-2500"
            .AddItem "Mach C-3000"
            .AddItem "Mach C-4000"
            .AddItem "MFD-750"
            .AddItem "MFD-1000"
            .AddItem "MFD-1500"
            .AddItem "MFD-2000"
            .AddItem "MFD-2500"
            .AddItem "MFD-3000"
            .AddItem "Sonic SC-650"
            .AddItem "Sonic SC-650GG"
            .AddItem "Sonic SC-750"
            .AddItem "Sonic SC-750GG"
            .AddItem "Sonic SC-850"
            .AddItem "Sonic SC-850GG"
            .AddItem "Sonic SC-1000"
            .AddItem "Sonic SC-1000GG"
                
            
            
        End With
'PVI
    Case Is = 7
        With ComboBox2
            .AddItem "Tricon 50 L 300A-PVIF"
            .AddItem "Tricon 75 L 300A-PVIF"
            .AddItem "Tricon 100 SL 300A-PVIF"
            .AddItem "Tricon 150 L 300A-PVIF"
            .AddItem "Tricon 180 L 300A-PVIF"
            .AddItem "Tricon 200 L 300A-PVIF"
            .AddItem "Tricon 150 L 250A-PVIF"
            .AddItem "Tricon 180 L 250A-PVIF"
            .AddItem "Tricon 200 L 250A-PVIF"
        
        End With
'RBI
    Case Is = 8
        With ComboBox2
            .AddItem "FlexCore CK-850"
            .AddItem "FlexCore CK-1000"
            .AddItem "FlexCore CK-1500"
            .AddItem "FlexCore CK-2000"
            .AddItem "FlexCore CK-2500"
            .AddItem "FlexCore CK-3000"
            .AddItem "FlexCore CK-3500"
            .AddItem "FlexCore CK-4000"
            .AddItem "FlexCore CK-4500"
            .AddItem "FlexCore CK-5000"
            .AddItem "FlexCore CK-6000"

        End With
'Riello
    Case Is = 9
        With ComboBox2
            .AddItem "Array AR-1000"
            .AddItem "Array AR-1500"
            .AddItem "Array AR-2000"
            .AddItem "Array AR-3000"
            .AddItem "Array AR-4000"

        End With



End Select

End Sub



Private Sub CommandButton1_Click()

Range("R2").Value = ComboBox1.Value
Range("R3").Value = ComboBox2.Value


Unload Me
End Sub


