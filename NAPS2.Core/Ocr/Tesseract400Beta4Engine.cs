﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NAPS2.Config;
using NAPS2.Dependencies;

namespace NAPS2.Ocr
{
    public class Tesseract400Beta4Engine : TesseractBaseEngine
    {
        public Tesseract400Beta4Engine(AppConfigManager appConfigManager) : base(appConfigManager)
        {
        }

        protected override string TesseractBasePath => Path.Combine(ExternalComponent.BasePath, "tesseract-4.0.0b4");

        protected override string TesseractExePath => "tesseract.exe";

        protected override string TesseractPrefixPath => Path.Combine(TesseractBasePath, "tessdata");

        protected override string TesseractHocrExtension => ".html";

        protected override PlatformSupport PlatformSupport => PlatformSupport.ModernWindows;

        public override bool IsUpgradable => false;

        public override bool CanInstall => false;
    }
}