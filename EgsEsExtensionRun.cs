Locales.Language lng = Locales.Language.enGB;

CpuInfDev.Run(CsRoot.Root, lng);          	// draws defective devices
CpuInfCpu.Run(CsRoot.Root, lng);          	// draws processor device health information
CpuInfHll.Run(CsRoot.Root, lng);     	   	// draws a structure damage overview scheme

CpuInfBox.Run(CsRoot.Root, lng);          	// draws container fill levels
CpuInfBay.Run(CsRoot.Root, lng);         	// draws docked vessel data
CpuInfThr.Run(CsRoot.Root, lng);          	// draws thruster health information
CpuInfWpn.Run(CsRoot.Root, lng);          	// draws weapon health information

CpuCvrSrt.Run(CsRoot.Root, lng);          	// reads levels and items needs and try to preserve the item count for specified containers
CpuCvrPrg.Run(CsRoot.Root, lng);         	// gather all items from defined containers/vessels (much logic/security conditions)
CpuCvrFll.Run(CsRoot.Root, lng);          	// reads item requests from vessels and try to refill it (much logic/security conditions)

CpuInfS.Run(CsRoot.Root, lng);            	// draws compact information overview for smaller displays
CpuInfL.Run(CsRoot.Root, lng);            	// draws information overview for bigger displays
