//
//  BlinkID.h
//  BlinkID
//
//  Created by Jura on 24/02/16.
//  Copyright © 2016 MicroBlink. All rights reserved.
//

#import <UIKit/UIKit.h>

@protocol BlinkIDDelegate;

@interface BlinkID : NSObject

@property (nonatomic, weak) id<BlinkIDDelegate> delegate;

@property (nonatomic) NSString *licenseKey;

+ (instancetype)instance;

// Recognizers

- (void)addAusIDBackRecognizer;

- (void)addAusIDFrontRecognizer;

- (void)addAusPassportRecognizer;

- (void)addAusIDCombinedRecognizer;

- (void)addAustraliaDLBackRecognizer;

- (void)addAustraliaDLFrontRecognizer;

- (void)addBarDecoderRecognizer;

- (void)addBarcodeRecognizer;

- (void)addCroIdBackRecognizer;

- (void)addCroIdFrontRecognizer;

- (void)addCroCombinedRecognizer;

- (void)addCzIDBackRecognizer;

- (void)addCzIDFrontRecognizer;

- (void)addCzCombinedRecognizer;

- (void)addEudlRecognizer;

- (void)addGerIDFrontRecognizer;

- (void)addGerIDBackRecognizer;

- (void)addGerIDOldRecognizer;

- (void)addGerPassportRecognizer;

- (void)addGerCombinedRecognizer;

- (void)addMrtdRecognizer;

- (void)addMyKadRecognizer;

- (void)addIKadRecognizer;

- (void)addPdf417Recognizer;

- (void)addSerbIDBackRecognizer;

- (void)addSerbIDFrontRecognizer;

- (void)addSerbIDCombinedRecognizer;

- (void)addSlovakIDFrontRecognizer;

- (void)addSlovakIDBackRecognizer;

- (void)addSlovakCombinedRecognizer;

- (void)addSlovenianIDBackRecognizer;

- (void)addSlovenianIDFrontRecognizer;

- (void)addSlovenianCombinedRecognizer;

- (void)addSingaporeIDBackRecognizer;

- (void)addSingaporeIDFrontRecognizer;

- (void)addSingaporeCombinedRecognizer;

- (void)addSwissPassportRecognizer;

- (void)addUsdlRecognizer;

- (void)addAusdlRecognizer;

- (void)addUkdlRecognizer;

- (void)addDedlRecognizer;

- (void)addZXingRecognizer;

- (void)addVinRecognizer;

- (void)addMrtdCombinedRecognizer;

// Parsers

- (void)addRawParser:(NSString *)identifier;

- (void)addAmountParser:(NSString *)identifier;

- (void)addDateParser:(NSString *)identifier;

- (void)addEmailParser:(NSString *)identifier;

- (void)addIbanParser:(NSString *)identifier;

- (void)addVinParser:(NSString *)identifierd;

- (void)addLicensePlatesParser:(NSString *)identifier;

- (void)addTopUpOcrParser:(NSString *)identifier;

- (void)addRegexParser:(NSString *)regex identifier:(NSString *)identifier;

// Detectors
- (void)addIdCardDetector;

// Clearing

- (void)clearAllRecognizers;

- (void)clearAllParsers;

- (void)clearAllDetectors;

// Scan

- (void)scan:(BOOL)isFrontCamera;

@end


@protocol BlinkIDDelegate <NSObject>

- (void)blinkID:(BlinkID *)blinkid
didOutputResults:(NSArray<NSDictionary *> *)results;

- (void)blinkID:(BlinkID *)blinkid
 didOutputImage:(UIImage *)image
           name:(NSString *)name;

@end

// In this header, you should import all the public headers of your framework using statements like #import <BlinkID/PublicHeader.h>


