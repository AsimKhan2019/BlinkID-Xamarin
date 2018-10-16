﻿using Microblink.Forms.Droid.Recognizers;
using Microblink.Forms.Core.Recognizers;

[assembly: Xamarin.Forms.Dependency(typeof(CyprusIdFrontRecognizer))]
namespace Microblink.Forms.Droid.Recognizers
{
    public sealed class CyprusIdFrontRecognizer : Recognizer, ICyprusIdFrontRecognizer
    {
        Com.Microblink.Entities.Recognizers.Blinkid.Cyprus.CyprusIdFrontRecognizer nativeRecognizer;

        CyprusIdFrontRecognizerResult result;

        public CyprusIdFrontRecognizer() : base(new Com.Microblink.Entities.Recognizers.Blinkid.Cyprus.CyprusIdFrontRecognizer())
        {
            nativeRecognizer = NativeRecognizer as Com.Microblink.Entities.Recognizers.Blinkid.Cyprus.CyprusIdFrontRecognizer;
            result = new CyprusIdFrontRecognizerResult(nativeRecognizer.GetResult() as Com.Microblink.Entities.Recognizers.Blinkid.Cyprus.CyprusIdFrontRecognizer.Result);
        }

        public override IRecognizerResult BaseResult => result;

        public ICyprusIdFrontRecognizerResult Result => result;

        
        public bool DetectGlare 
        { 
            get => nativeRecognizer.ShouldDetectGlare(); 
            set => nativeRecognizer.SetDetectGlare(value);
        }
        
        public bool ExtractDocumentNumber 
        { 
            get => nativeRecognizer.ShouldExtractDocumentNumber(); 
            set => nativeRecognizer.SetExtractDocumentNumber(value);
        }
        
        public bool ExtractName 
        { 
            get => nativeRecognizer.ShouldExtractName(); 
            set => nativeRecognizer.SetExtractName(value);
        }
        
        public bool ExtractSurname 
        { 
            get => nativeRecognizer.ShouldExtractSurname(); 
            set => nativeRecognizer.SetExtractSurname(value);
        }
        
        public uint FaceImageDpi 
        { 
            get => (uint)nativeRecognizer.FaceImageDpi; 
            set => nativeRecognizer.FaceImageDpi = (int)value;
        }
        
        public uint FullDocumentImageDpi 
        { 
            get => (uint)nativeRecognizer.FullDocumentImageDpi; 
            set => nativeRecognizer.FullDocumentImageDpi = (int)value;
        }
        
        public IImageExtensionFactors FullDocumentImageExtensionFactors 
        { 
            get => new ImageExtensionFactors(nativeRecognizer.FullDocumentImageExtensionFactors); 
            set => nativeRecognizer.FullDocumentImageExtensionFactors = (value as ImageExtensionFactors).NativeImageExtensionFactors;
        }
        
        public bool ReturnFaceImage 
        { 
            get => nativeRecognizer.ShouldReturnFaceImage(); 
            set => nativeRecognizer.SetReturnFaceImage(value);
        }
        
        public bool ReturnFullDocumentImage 
        { 
            get => nativeRecognizer.ShouldReturnFullDocumentImage(); 
            set => nativeRecognizer.SetReturnFullDocumentImage(value);
        }
        
    }

    public sealed class CyprusIdFrontRecognizerResult : RecognizerResult, ICyprusIdFrontRecognizerResult
    {
        Com.Microblink.Entities.Recognizers.Blinkid.Cyprus.CyprusIdFrontRecognizer.Result nativeResult;

        internal CyprusIdFrontRecognizerResult(Com.Microblink.Entities.Recognizers.Blinkid.Cyprus.CyprusIdFrontRecognizer.Result nativeResult) : base(nativeResult)
        {
            this.nativeResult = nativeResult;
        }
        public string DocumentNumber => nativeResult.DocumentNumber;
        public Xamarin.Forms.ImageSource FaceImage => nativeResult.FaceImage != null ? Utils.ConvertAndroidBitmap(nativeResult.FaceImage.ConvertToBitmap()) : null;
        public Xamarin.Forms.ImageSource FullDocumentImage => nativeResult.FullDocumentImage != null ? Utils.ConvertAndroidBitmap(nativeResult.FullDocumentImage.ConvertToBitmap()) : null;
        public string IdNumber => nativeResult.IdNumber;
        public string Name => nativeResult.Name;
        public string Surname => nativeResult.Surname;
    }
}