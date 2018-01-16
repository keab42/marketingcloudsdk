﻿using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace marketingcloudsdkIOS
{
    // @interface UNNotificationCategory : NSObject <NSCopying, NSSecureCoding>
    [Watch(3, 0), NoTV, iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNNotificationCategory : INSCopying, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSArray<UNNotificationAction *> * _Nonnull actions;
        [Export("actions", ArgumentSemantic.Copy)]
        UNNotificationAction[] Actions { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull intentIdentifiers;
        [Export("intentIdentifiers", ArgumentSemantic.Copy)]
        string[] IntentIdentifiers { get; }

        // @property (readonly, nonatomic) UNNotificationCategoryOptions options;
        [Export("options")]
        UNNotificationCategoryOptions Options { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull hiddenPreviewsBodyPlaceholder __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=11.0)));
        [NoWatch, iOS(11, 0)]
        [Export("hiddenPreviewsBodyPlaceholder")]
        string HiddenPreviewsBodyPlaceholder { get; }

        // +(instancetype _Nonnull)categoryWithIdentifier:(NSString * _Nonnull)identifier actions:(NSArray<UNNotificationAction *> * _Nonnull)actions intentIdentifiers:(NSArray<NSString *> * _Nonnull)intentIdentifiers options:(UNNotificationCategoryOptions)options;
        [Static]
        [Export("categoryWithIdentifier:actions:intentIdentifiers:options:")]
        UNNotificationCategory CategoryWithIdentifier(string identifier, UNNotificationAction[] actions, string[] intentIdentifiers, UNNotificationCategoryOptions options);

        // +(instancetype _Nonnull)categoryWithIdentifier:(NSString * _Nonnull)identifier actions:(NSArray<UNNotificationAction *> * _Nonnull)actions intentIdentifiers:(NSArray<NSString *> * _Nonnull)intentIdentifiers hiddenPreviewsBodyPlaceholder:(NSString * _Nonnull)hiddenPreviewsBodyPlaceholder options:(UNNotificationCategoryOptions)options __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=11.0)));
        [NoWatch, iOS(11, 0)]
        [Static]
        [Export("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:options:")]
        UNNotificationCategory CategoryWithIdentifier(string identifier, UNNotificationAction[] actions, string[] intentIdentifiers, string hiddenPreviewsBodyPlaceholder, UNNotificationCategoryOptions options);
    }

   
    // @interface UNNotification : NSObject <NSCopying, NSSecureCoding>
    [Watch(3, 0), TV(10, 0), iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNNotification : INSCopying, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSDate * _Nonnull date;
        [Export("date", ArgumentSemantic.Copy)]
        NSDate Date { get; }

        // @property (readonly, copy, nonatomic) UNNotificationRequest * _Nonnull request;
        [Export("request", ArgumentSemantic.Copy)]
        UNNotificationRequest Request { get; }
    }

    // @interface UNNotificationAction : NSObject <NSCopying, NSSecureCoding>
    [Watch(3, 0), NoTV, iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNNotificationAction : INSCopying, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) UNNotificationActionOptions options;
        [Export("options")]
        UNNotificationActionOptions Options { get; }

        // +(instancetype _Nonnull)actionWithIdentifier:(NSString * _Nonnull)identifier title:(NSString * _Nonnull)title options:(UNNotificationActionOptions)options;
        [Static]
        [Export("actionWithIdentifier:title:options:")]
        UNNotificationAction ActionWithIdentifier(string identifier, string title, UNNotificationActionOptions options);
    }

    // @interface UNTextInputNotificationAction : UNNotificationAction
    [Watch(3, 0), NoTV, iOS(10, 0)]
    [BaseType(typeof(UNNotificationAction))]
    interface UNTextInputNotificationAction
    {
        // +(instancetype _Nonnull)actionWithIdentifier:(NSString * _Nonnull)identifier title:(NSString * _Nonnull)title options:(UNNotificationActionOptions)options textInputButtonTitle:(NSString * _Nonnull)textInputButtonTitle textInputPlaceholder:(NSString * _Nonnull)textInputPlaceholder;
        [Static]
        [Export("actionWithIdentifier:title:options:textInputButtonTitle:textInputPlaceholder:")]
        UNTextInputNotificationAction ActionWithIdentifier(string identifier, string title, UNNotificationActionOptions options, string textInputButtonTitle, string textInputPlaceholder);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull textInputButtonTitle;
        [Export("textInputButtonTitle")]
        string TextInputButtonTitle { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull textInputPlaceholder;
        [Export("textInputPlaceholder")]
        string TextInputPlaceholder { get; }
    }

    // @interface UNNotificationAttachment : NSObject <NSCopying, NSSecureCoding>
    [Watch(3, 0), NoTV, iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNNotificationAttachment : INSCopying, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nonnull URL;
        [Export("URL", ArgumentSemantic.Copy)]
        NSUrl URL { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; }

        // +(instancetype _Nullable)attachmentWithIdentifier:(NSString * _Nonnull)identifier URL:(NSURL * _Nonnull)URL options:(NSDictionary * _Nullable)options error:(NSError * _Nullable * _Nullable)error;
        [Static]
        [Export("attachmentWithIdentifier:URL:options:error:")]
        [return: NullAllowed]
        UNNotificationAttachment AttachmentWithIdentifier(string identifier, NSUrl URL, [NullAllowed] NSDictionary options, [NullAllowed] out NSError error);
    }


    // @interface UNNotificationResponse : NSObject <NSCopying, NSSecureCoding>
    [Watch(3, 0), NoTV, iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNNotificationResponse : INSCopying, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) UNNotification * _Nonnull notification;
        [Export("notification", ArgumentSemantic.Copy)]
        UNNotification Notification { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull actionIdentifier;
        [Export("actionIdentifier")]
        string ActionIdentifier { get; }
    }

    // @interface UNTextInputNotificationResponse : UNNotificationResponse
    [Watch(3, 0), NoTV, iOS(10, 0)]
    [BaseType(typeof(UNNotificationResponse))]
    interface UNTextInputNotificationResponse
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull userText;
        [Export("userText")]
        string UserText { get; }
    }



    // @interface ETAnalytics : NSObject
    [BaseType(typeof(NSObject))]

    // @interface UNNotificationRequest : NSObject <NSCopying, NSSecureCoding>
    [Watch(3, 0), TV(10, 0), iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNNotificationRequest : INSCopying, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) UNNotificationContent * _Nonnull content;
        [Export("content", ArgumentSemantic.Copy)]
        UNNotificationContent Content { get; }

        // @property (readonly, copy, nonatomic) UNNotificationTrigger * _Nullable trigger;
        [NullAllowed, Export("trigger", ArgumentSemantic.Copy)]
        UNNotificationTrigger Trigger { get; }

        // +(instancetype _Nonnull)requestWithIdentifier:(NSString * _Nonnull)identifier content:(UNNotificationContent * _Nonnull)content trigger:(UNNotificationTrigger * _Nullable)trigger;
        [Static]
        [Export("requestWithIdentifier:content:trigger:")]
        UNNotificationRequest RequestWithIdentifier(string identifier, UNNotificationContent content, [NullAllowed] UNNotificationTrigger trigger);
    }

    // @interface UNNotificationSound : NSObject <NSCopying, NSSecureCoding>
    [Watch(3, 0), NoTV, iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNNotificationSound : INSCopying, INSSecureCoding
    {
        // +(instancetype _Nonnull)defaultSound;
        [Static]
        [Export("defaultSound")]
        UNNotificationSound DefaultSound();

        // +(instancetype _Nonnull)soundNamed:(NSString * _Nonnull)name __attribute__((availability(watchos, unavailable)));
        [NoWatch]
        [Static]
        [Export("soundNamed:")]
        UNNotificationSound SoundNamed(string name);
    }


    // @interface UNNotificationContent : NSObject <NSCopying, NSMutableCopying, NSSecureCoding>
    [Watch(3, 0), TV(10, 0), iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    interface UNNotificationContent : INSCopying, INSMutableCopying, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSArray<UNNotificationAttachment *> * _Nonnull attachments __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("attachments", ArgumentSemantic.Copy)]
        UNNotificationAttachment[] Attachments { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable badge;
        [NullAllowed, Export("badge", ArgumentSemantic.Copy)]
        NSNumber Badge { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull body __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("body")]
        string Body { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull categoryIdentifier __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("categoryIdentifier")]
        string CategoryIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull launchImageName __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("launchImageName")]
        string LaunchImageName { get; }

        // @property (readonly, copy, nonatomic) UNNotificationSound * _Nullable sound __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [NullAllowed, Export("sound", ArgumentSemantic.Copy)]
        UNNotificationSound Sound { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull subtitle __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("subtitle")]
        string Subtitle { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull threadIdentifier __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("threadIdentifier")]
        string ThreadIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull title __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull userInfo __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("userInfo", ArgumentSemantic.Copy)]
        NSDictionary UserInfo { get; }
    }

    // @interface UNMutableNotificationContent : UNNotificationContent
    [Watch(3, 0), TV(10, 0), iOS(10, 0)]
    [BaseType(typeof(UNNotificationContent))]
    interface UNMutableNotificationContent
    {
        // @property (copy, nonatomic) NSArray<UNNotificationAttachment *> * _Nonnull attachments __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("attachments", ArgumentSemantic.Copy)]
        UNNotificationAttachment[] Attachments { get; set; }

        // @property (copy, nonatomic) NSNumber * _Nullable badge;
        [NullAllowed, Export("badge", ArgumentSemantic.Copy)]
        NSNumber Badge { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull body __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("body")]
        string Body { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull categoryIdentifier __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("categoryIdentifier")]
        string CategoryIdentifier { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull launchImageName __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("launchImageName")]
        string LaunchImageName { get; set; }

        // @property (copy, nonatomic) UNNotificationSound * _Nullable sound __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [NullAllowed, Export("sound", ArgumentSemantic.Copy)]
        UNNotificationSound Sound { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull subtitle __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("subtitle")]
        string Subtitle { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull threadIdentifier __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("threadIdentifier")]
        string ThreadIdentifier { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull title __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull userInfo;
        [Export("userInfo", ArgumentSemantic.Copy)]
        NSDictionary UserInfo { get; set; }
    }

    // @interface UNNotificationTrigger : NSObject <NSCopying, NSSecureCoding>
    [Watch(3, 0), TV(10, 0), iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNNotificationTrigger : INSCopying, INSSecureCoding
    {
        // @property (readonly, nonatomic) BOOL repeats;
        [Export("repeats")]
        bool Repeats { get; }
    }

    // @interface UNPushNotificationTrigger : UNNotificationTrigger
    [Watch(3, 0), TV(10, 0), iOS(10, 0)]
    [BaseType(typeof(UNNotificationTrigger))]
    interface UNPushNotificationTrigger
    {
    }

    // @interface UNTimeIntervalNotificationTrigger : UNNotificationTrigger
    [Watch(3, 0), TV(10, 0), iOS(10, 0)]
    [BaseType(typeof(UNNotificationTrigger))]
    interface UNTimeIntervalNotificationTrigger
    {
        // @property (readonly, nonatomic) NSTimeInterval timeInterval;
        [Export("timeInterval")]
        double TimeInterval { get; }

        // +(instancetype _Nonnull)triggerWithTimeInterval:(NSTimeInterval)timeInterval repeats:(BOOL)repeats;
        [Static]
        [Export("triggerWithTimeInterval:repeats:")]
        UNTimeIntervalNotificationTrigger TriggerWithTimeInterval(double timeInterval, bool repeats);

        // -(NSDate * _Nullable)nextTriggerDate;
        [NullAllowed, Export("nextTriggerDate")]
        [Verify(MethodToProperty)]
        NSDate NextTriggerDate { get; }
    }

    // @interface UNCalendarNotificationTrigger : UNNotificationTrigger
    [Watch(3, 0), TV(10, 0), iOS(10, 0)]
    [BaseType(typeof(UNNotificationTrigger))]
    interface UNCalendarNotificationTrigger
    {
        // @property (readonly, copy, nonatomic) NSDateComponents * _Nonnull dateComponents;
        [Export("dateComponents", ArgumentSemantic.Copy)]
        NSDateComponents DateComponents { get; }

        // +(instancetype _Nonnull)triggerWithDateMatchingComponents:(NSDateComponents * _Nonnull)dateComponents repeats:(BOOL)repeats;
        [Static]
        [Export("triggerWithDateMatchingComponents:repeats:")]
        UNCalendarNotificationTrigger TriggerWithDateMatchingComponents(NSDateComponents dateComponents, bool repeats);

        // -(NSDate * _Nullable)nextTriggerDate;
        [NullAllowed, Export("nextTriggerDate")]
        [Verify(MethodToProperty)]
        NSDate NextTriggerDate { get; }
    }

    // @interface UNLocationNotificationTrigger : UNNotificationTrigger
    [Watch(3, 0), NoTV, iOS(10, 0)]
    [BaseType(typeof(UNNotificationTrigger))]
    interface UNLocationNotificationTrigger
    {
        // @property (readonly, copy, nonatomic) CLRegion * _Nonnull region;
        [Export("region", ArgumentSemantic.Copy)]
        CLRegion Region { get; }

        // +(instancetype _Nonnull)triggerWithRegion:(CLRegion * _Nonnull)region repeats:(BOOL)repeats __attribute__((availability(watchos, unavailable)));
        [NoWatch]
        [Static]
        [Export("triggerWithRegion:repeats:")]
        UNLocationNotificationTrigger TriggerWithRegion(CLRegion region, bool repeats);
    }


    interface ETAnalytics
    {
        // +(void)trackPageView:(NSString * _Nonnull)url andTitle:(NSString * _Nullable)title andItem:(NSString * _Nullable)item andSearch:(NSString * _Nullable)search;
        [Static]
        [Export("trackPageView:andTitle:andItem:andSearch:")]
        void TrackPageView(string url, [NullAllowed] string title, [NullAllowed] string item, [NullAllowed] string search);

        // +(void)trackCartContents:(PICart * _Nonnull)cart;
        [Static]
        [Export("trackCartContents:")]
        void TrackCartContents(PICart cart);

        // +(void)trackCartConversion:(PIOrder * _Nonnull)order;
        [Static]
        [Export("trackCartConversion:")]
        void TrackCartConversion(PIOrder order);
    }

    // @interface UIUserNotificationSettings : NSObject
    [Introduced(PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's UNNotificationSettings")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's UNNotificationSettings")]
    [NoTV]
    [BaseType(typeof(NSObject))]
    interface UIUserNotificationSettings
    {
        // +(instancetype _Nonnull)settingsForTypes:(UIUserNotificationType)types categories:(NSSet<UIUserNotificationCategory *> * _Nullable)categories;
        [Static]
        [Export("settingsForTypes:categories:")]
        UIUserNotificationSettings SettingsForTypes(UIUserNotificationType types, [NullAllowed] NSSet<UIUserNotificationCategory> categories);

        // @property (readonly, nonatomic) UIUserNotificationType types;
        [Export("types")]
        UIUserNotificationType Types { get; }

        // @property (readonly, copy, nonatomic) NSSet<UIUserNotificationCategory *> * _Nullable categories;
        [NullAllowed, Export("categories", ArgumentSemantic.Copy)]
        NSSet<UIUserNotificationCategory> Categories { get; }
    }

    // @interface UIUserNotificationCategory : NSObject <NSCopying, NSMutableCopying, NSSecureCoding>
    [Introduced(PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's UNNotificationCategory")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's UNNotificationCategory")]
    [NoTV]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UIUserNotificationCategory : INSCopying, INSMutableCopying, INSSecureCoding
    {
        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((availability(tvos, unavailable))) __attribute__((objc_designated_initializer));
        [NoTV]
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // @property (readonly, copy, nonatomic) NSString * _Nullable identifier __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [NullAllowed, Export("identifier")]
        string Identifier { get; }

        // -(NSArray<UIUserNotificationAction *> * _Nullable)actionsForContext:(UIUserNotificationActionContext)context __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("actionsForContext:")]
        [return: NullAllowed]
        UIUserNotificationAction[] ActionsForContext(UIUserNotificationActionContext context);
    }

    // @interface UIMutableUserNotificationCategory : UIUserNotificationCategory
    [Introduced(PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's UNNotificationCategory")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's UNNotificationCategory")]
    [NoTV]
    [BaseType(typeof(UIUserNotificationCategory))]
    interface UIMutableUserNotificationCategory
    {
        // @property (copy, nonatomic) NSString * _Nullable identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // -(void)setActions:(NSArray<UIUserNotificationAction *> * _Nullable)actions forContext:(UIUserNotificationActionContext)context;
        [Export("setActions:forContext:")]
        void SetActions([NullAllowed] UIUserNotificationAction[] actions, UIUserNotificationActionContext context);
    }

    // @interface UIUserNotificationAction : NSObject <NSCopying, NSMutableCopying, NSSecureCoding>
    [Introduced(PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's UNNotificationAction")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's UNNotificationAction")]
    [NoTV]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UIUserNotificationAction : INSCopying, INSMutableCopying, INSSecureCoding
    {
        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((availability(tvos, unavailable))) __attribute__((objc_designated_initializer));
        [NoTV]
        [Export("initWithCoder:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSCoder aDecoder);

        // @property (readonly, copy, nonatomic) NSString * _Nullable identifier __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [NullAllowed, Export("identifier")]
        string Identifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable title __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, assign, nonatomic) UIUserNotificationActionBehavior behavior __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, introduced=9_0)));
        [NoTV, iOS(9, 0)]
        [Export("behavior", ArgumentSemantic.Assign)]
        UIUserNotificationActionBehavior Behavior { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull parameters __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, introduced=9_0)));
        [NoTV, iOS(9, 0)]
        [Export("parameters", ArgumentSemantic.Copy)]
        NSDictionary Parameters { get; }

        // @property (readonly, assign, nonatomic) UIUserNotificationActivationMode activationMode __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("activationMode", ArgumentSemantic.Assign)]
        UIUserNotificationActivationMode ActivationMode { get; }

        // @property (readonly, getter = isAuthenticationRequired, assign, nonatomic) BOOL authenticationRequired __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("authenticationRequired")]
        bool AuthenticationRequired { [Bind("isAuthenticationRequired")] get; }

        // @property (readonly, getter = isDestructive, assign, nonatomic) BOOL destructive __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("destructive")]
        bool Destructive { [Bind("isDestructive")] get; }
    }

    // @interface UIMutableUserNotificationAction : UIUserNotificationAction
    [Introduced(PlatformName.iOS, 8, 0, message: "Use UserNotifications Framework's UNNotificationAction")]
    [Deprecated(PlatformName.iOS, 10, 0, message: "Use UserNotifications Framework's UNNotificationAction")]
    [NoTV]
    [BaseType(typeof(UIUserNotificationAction))]
    interface UIMutableUserNotificationAction
    {
        // @property (copy, nonatomic) NSString * _Nullable identifier;
        [NullAllowed, Export("identifier")]
        string Identifier { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; set; }

        // @property (assign, nonatomic) UIUserNotificationActionBehavior behavior __attribute__((availability(ios, introduced=9_0)));
        [iOS(9, 0)]
        [Export("behavior", ArgumentSemantic.Assign)]
        UIUserNotificationActionBehavior Behavior { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull parameters __attribute__((availability(ios, introduced=9_0)));
        [iOS(9, 0)]
        [Export("parameters", ArgumentSemantic.Copy)]
        NSDictionary Parameters { get; set; }

        // @property (assign, nonatomic) UIUserNotificationActivationMode activationMode;
        [Export("activationMode", ArgumentSemantic.Assign)]
        UIUserNotificationActivationMode ActivationMode { get; set; }

        // @property (getter = isAuthenticationRequired, assign, nonatomic) BOOL authenticationRequired;
        [Export("authenticationRequired")]
        bool AuthenticationRequired { [Bind("isAuthenticationRequired")] get; set; }

        // @property (getter = isDestructive, assign, nonatomic) BOOL destructive;
        [Export("destructive")]
        bool Destructive { [Bind("isDestructive")] get; set; }
    }

    // @interface UIFocusSystem : NSObject
    [iOS(11, 0)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UIFocusSystem
    {
        // +(BOOL)environment:(id<UIFocusEnvironment> _Nonnull)environment containsEnvironment:(id<UIFocusEnvironment> _Nonnull)otherEnvironment;
        [Static]
        [Export("environment:containsEnvironment:")]
        bool Environment(UIFocusEnvironment environment, UIFocusEnvironment otherEnvironment);

        // +(void)registerURL:(NSURL * _Nonnull)soundFileURL forSoundIdentifier:(UIFocusSoundIdentifier _Nonnull)identifier __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, unavailable))) __attribute__((availability(tvos, introduced=11.0)));
        [TV(11, 0), NoWatch, NoiOS]
        [Static]
        [Export("registerURL:forSoundIdentifier:")]
        void RegisterURL(NSUrl soundFileURL, string identifier);
    }

    // @interface UIFocusDebugger : NSObject
    [iOS(11, 0)]
    [BaseType(typeof(NSObject))]
    interface UIFocusDebugger
    {
        // +(id<UIFocusDebuggerOutput> _Nonnull)help;
        [Static]
        [Export("help")]
        [Verify(MethodToProperty)]
        UIFocusDebuggerOutput Help { get; }

        // +(id<UIFocusDebuggerOutput> _Nonnull)status;
        [Static]
        [Export("status")]
        [Verify(MethodToProperty)]
        UIFocusDebuggerOutput Status { get; }

        // +(id<UIFocusDebuggerOutput> _Nonnull)checkFocusabilityForItem:(id<UIFocusItem> _Nonnull)item;
        [Static]
        [Export("checkFocusabilityForItem:")]
        UIFocusDebuggerOutput CheckFocusabilityForItem(UIFocusItem item);

        // +(id<UIFocusDebuggerOutput> _Nonnull)simulateFocusUpdateRequestFromEnvironment:(id<UIFocusEnvironment> _Nonnull)environment;
        [Static]
        [Export("simulateFocusUpdateRequestFromEnvironment:")]
        UIFocusDebuggerOutput SimulateFocusUpdateRequestFromEnvironment(UIFocusEnvironment environment);
    }

    // @protocol UIFocusDebuggerOutput <NSObject>
    [iOS(11, 0)]
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface UIFocusDebuggerOutput
    {
    }


    // @interface UNNotificationServiceExtension : NSObject
    [NoWatch, NoTV, iOS(10, 0)]
    [BaseType(typeof(NSObject))]
    interface UNNotificationServiceExtension
    {
        // -(void)didReceiveNotificationRequest:(UNNotificationRequest * _Nonnull)request withContentHandler:(void (^ _Nonnull)(UNNotificationContent * _Nonnull))contentHandler;
        [Export("didReceiveNotificationRequest:withContentHandler:")]
        void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler);

        // -(void)serviceExtensionTimeWillExpire;
        [Export("serviceExtensionTimeWillExpire")]
        void ServiceExtensionTimeWillExpire();
    }


    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface UNUserNotificationCenter
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        UNUserNotificationCenterDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<UNUserNotificationCenterDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) BOOL supportsContentExtensions;
        [Export("supportsContentExtensions")]
        bool SupportsContentExtensions { get; }

        // +(UNUserNotificationCenter * _Nonnull)currentNotificationCenter;
        [Static]
        [Export("currentNotificationCenter")]
        [Verify(MethodToProperty)]
        UNUserNotificationCenter CurrentNotificationCenter { get; }

        // -(void)requestAuthorizationWithOptions:(UNAuthorizationOptions)options completionHandler:(void (^ _Nonnull)(BOOL, NSError * _Nullable))completionHandler;
        [Export("requestAuthorizationWithOptions:completionHandler:")]
        void RequestAuthorizationWithOptions(UNAuthorizationOptions options, Action<bool, NSError> completionHandler);

        // -(void)setNotificationCategories:(NSSet<UNNotificationCategory *> * _Nonnull)categories __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("setNotificationCategories:")]
        void SetNotificationCategories(NSSet<UNNotificationCategory> categories);

        // -(void)getNotificationCategoriesWithCompletionHandler:(void (^ _Nonnull)(NSSet<UNNotificationCategory *> * _Nonnull))completionHandler __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("getNotificationCategoriesWithCompletionHandler:")]
        void GetNotificationCategoriesWithCompletionHandler(Action<NSSet<UNNotificationCategory>> completionHandler);

        // -(void)getNotificationSettingsWithCompletionHandler:(void (^ _Nonnull)(UNNotificationSettings * _Nonnull))completionHandler;
        [Export("getNotificationSettingsWithCompletionHandler:")]
        void GetNotificationSettingsWithCompletionHandler(Action<UNNotificationSettings> completionHandler);

        // -(void)addNotificationRequest:(UNNotificationRequest * _Nonnull)request withCompletionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
        [Export("addNotificationRequest:withCompletionHandler:")]
        void AddNotificationRequest(UNNotificationRequest request, [NullAllowed] Action<NSError> completionHandler);

        // -(void)getPendingNotificationRequestsWithCompletionHandler:(void (^ _Nonnull)(NSArray<UNNotificationRequest *> * _Nonnull))completionHandler;
        [Export("getPendingNotificationRequestsWithCompletionHandler:")]
        void GetPendingNotificationRequestsWithCompletionHandler(Action<NSArray<UNNotificationRequest>> completionHandler);

        // -(void)removePendingNotificationRequestsWithIdentifiers:(NSArray<NSString *> * _Nonnull)identifiers;
        [Export("removePendingNotificationRequestsWithIdentifiers:")]
        void RemovePendingNotificationRequestsWithIdentifiers(string[] identifiers);

        // -(void)removeAllPendingNotificationRequests;
        [Export("removeAllPendingNotificationRequests")]
        void RemoveAllPendingNotificationRequests();

        // -(void)getDeliveredNotificationsWithCompletionHandler:(void (^ _Nonnull)(NSArray<UNNotification *> * _Nonnull))completionHandler __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("getDeliveredNotificationsWithCompletionHandler:")]
        void GetDeliveredNotificationsWithCompletionHandler(Action<NSArray<UNNotification>> completionHandler);

        // -(void)removeDeliveredNotificationsWithIdentifiers:(NSArray<NSString *> * _Nonnull)identifiers __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("removeDeliveredNotificationsWithIdentifiers:")]
        void RemoveDeliveredNotificationsWithIdentifiers(string[] identifiers);

        // -(void)removeAllDeliveredNotifications __attribute__((availability(tvos, unavailable)));
        [NoTV]
        [Export("removeAllDeliveredNotifications")]
        void RemoveAllDeliveredNotifications();
    }

    interface UNUserNotificationCenterDelegate
    {
        // @optional -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center willPresentNotification:(UNNotification * _Nonnull)notification withCompletionHandler:(void (^ _Nonnull)(UNNotificationPresentationOptions))completionHandler __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0))) __attribute__((availability(ios, introduced=10.0)));
        [Watch(3, 0), TV(10, 0), iOS(10, 0)]
        [Export("userNotificationCenter:willPresentNotification:withCompletionHandler:")]
        void WillPresentNotification(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler);

        // @optional -(void)userNotificationCenter:(UNUserNotificationCenter * _Nonnull)center didReceiveNotificationResponse:(UNNotificationResponse * _Nonnull)response withCompletionHandler:(void (^ _Nonnull)(void))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(ios, introduced=10.0)));
        [Watch(3, 0), NoTV, iOS(10, 0)]
        [Export("userNotificationCenter:didReceiveNotificationResponse:withCompletionHandler:")]
        void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);
    }


    // @interface CLBeaconRegion : CLRegion
    [NoWatch, NoTV, iOS(7, 0)]
    [BaseType(typeof(CLRegion))]
    interface CLBeaconRegion
    {
        // -(instancetype _Nonnull)initWithProximityUUID:(NSUUID * _Nonnull)proximityUUID identifier:(NSString * _Nonnull)identifier;
        [Export("initWithProximityUUID:identifier:")]
        IntPtr Constructor(NSUuid proximityUUID, string identifier);

        // -(instancetype _Nonnull)initWithProximityUUID:(NSUUID * _Nonnull)proximityUUID major:(CLBeaconMajorValue)major identifier:(NSString * _Nonnull)identifier;
        [Export("initWithProximityUUID:major:identifier:")]
        IntPtr Constructor(NSUuid proximityUUID, ushort major, string identifier);

        // -(instancetype _Nonnull)initWithProximityUUID:(NSUUID * _Nonnull)proximityUUID major:(CLBeaconMajorValue)major minor:(CLBeaconMinorValue)minor identifier:(NSString * _Nonnull)identifier;
        [Export("initWithProximityUUID:major:minor:identifier:")]
        IntPtr Constructor(NSUuid proximityUUID, ushort major, ushort minor, string identifier);

        // -(NSMutableDictionary<NSString *,id> * _Nonnull)peripheralDataWithMeasuredPower:(NSNumber * _Nullable)measuredPower;
        [Export("peripheralDataWithMeasuredPower:")]
        NSMutableDictionary<NSString, NSObject> PeripheralDataWithMeasuredPower([NullAllowed] NSNumber measuredPower);

        // @property (readonly, copy, nonatomic) NSUUID * _Nonnull proximityUUID;
        [Export("proximityUUID", ArgumentSemantic.Copy)]
        NSUuid ProximityUUID { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable major;
        [NullAllowed, Export("major", ArgumentSemantic.Copy)]
        NSNumber Major { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable minor;
        [NullAllowed, Export("minor", ArgumentSemantic.Copy)]
        NSNumber Minor { get; }

        // @property (assign, nonatomic) BOOL notifyEntryStateOnDisplay;
        [Export("notifyEntryStateOnDisplay")]
        bool NotifyEntryStateOnDisplay { get; set; }
    }

    // @interface CLBeacon : NSObject <NSCopying, NSSecureCoding>
    [NoWatch, NoTV, iOS(7, 0)]
    [BaseType(typeof(NSObject))]
    interface CLBeacon : INSCopying, INSSecureCoding
    {
        // @property (readonly, copy, nonatomic) NSUUID * _Nonnull proximityUUID;
        [Export("proximityUUID", ArgumentSemantic.Copy)]
        NSUuid ProximityUUID { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nonnull major;
        [Export("major", ArgumentSemantic.Copy)]
        NSNumber Major { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nonnull minor;
        [Export("minor", ArgumentSemantic.Copy)]
        NSNumber Minor { get; }

        // @property (readonly, nonatomic) CLProximity proximity;
        [Export("proximity")]
        CLProximity Proximity { get; }

        // @property (readonly, nonatomic) CLLocationAccuracy accuracy;
        [Export("accuracy")]
        double Accuracy { get; }

        // @property (readonly, nonatomic) NSInteger rssi;
        [Export("rssi")]
        nint Rssi { get; }
    }

    // @interface ETCloudPage : NSObject
    [BaseType(typeof(NSObject))]
    interface ETCloudPage
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable messageIdentifier;
        [NullAllowed, Export("messageIdentifier")]
        string MessageIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable messageName;
        [NullAllowed, Export("messageName")]
        string MessageName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable alert;
        [NullAllowed, Export("alert")]
        string Alert { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable category;
        [NullAllowed, Export("category")]
        string Category { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable keyValuePairs;
        [NullAllowed, Export("keyValuePairs", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] KeyValuePairs { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable startDate;
        [NullAllowed, Export("startDate", ArgumentSemantic.Copy)]
        NSDate StartDate { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable endDate;
        [NullAllowed, Export("endDate", ArgumentSemantic.Copy)]
        NSDate EndDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable siteUrlAsString;
        [NullAllowed, Export("siteUrlAsString")]
        string SiteUrlAsString { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable openDirectPayload;
        [NullAllowed, Export("openDirectPayload")]
        string OpenDirectPayload { get; }

        // @property (readonly, getter = isRead, nonatomic) BOOL read;
        [Export("read")]
        bool Read { [Bind("isRead")] get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable subject;
        [NullAllowed, Export("subject")]
        string Subject { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nullable siteURL;
        [NullAllowed, Export("siteURL", ArgumentSemantic.Copy)]
        NSUrl SiteURL { get; }

        // -(BOOL)markAsDeleted;
        [Export("markAsDeleted")]
        //[Verify(MethodToProperty)]
        bool MarkAsDeleted { get; }

        // -(BOOL)markAsRead;
        [Export("markAsRead")]
        //[Verify(MethodToProperty)]
        bool MarkAsRead { get; }
    }

    // @interface ETCloudPageDataSource : NSObject <UITableViewDataSource>
    [BaseType(typeof(NSObject))]
    interface ETCloudPageDataSource : IUITableViewDataSource
    {
        // @property (readonly, copy, nonatomic) NSArray<__kindof ETCloudPage *> * _Nullable messages;
        [NullAllowed, Export("messages", ArgumentSemantic.Copy)]
        ETCloudPage[] Messages { get; }

        // @property (nonatomic, weak) UITableView * _Nullable inboxTableView;
        [NullAllowed, Export("inboxTableView", ArgumentSemantic.Weak)]
        UITableView InboxTableView { get; set; }
    }

    // @interface ETEventMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface ETEventMessage
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable messageIdentifier;
        [NullAllowed, Export("messageIdentifier")]
        string MessageIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable messageName;
        [NullAllowed, Export("messageName")]
        string MessageName { get; }

        // @property (readonly, nonatomic) MobilePushMessageType messageType;
        [Export("messageType")]
        MobilePushMessageType MessageType { get; }

        // @property (readonly, nonatomic) MobilePushContentType contentType;
        [Export("contentType")]
        MobilePushContentType ContentType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable alert;
        [NullAllowed, Export("alert")]
        string Alert { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable sound;
        [NullAllowed, Export("sound")]
        string Sound { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable category;
        [NullAllowed, Export("category")]
        string Category { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable keyValuePairs;
        [NullAllowed, Export("keyValuePairs", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] KeyValuePairs { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable startDate;
        [NullAllowed, Export("startDate", ArgumentSemantic.Copy)]
        NSDate StartDate { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable endDate;
        [NullAllowed, Export("endDate", ArgumentSemantic.Copy)]
        NSDate EndDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable siteUrlAsString;
        [NullAllowed, Export("siteUrlAsString")]
        string SiteUrlAsString { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable openDirectPayload;
        [NullAllowed, Export("openDirectPayload")]
        string OpenDirectPayload { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable messageLimit;
        [NullAllowed, Export("messageLimit", ArgumentSemantic.Copy)]
        NSNumber MessageLimit { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable messagesPerPeriod;
        [NullAllowed, Export("messagesPerPeriod", ArgumentSemantic.Copy)]
        NSNumber MessagesPerPeriod { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable numberOfPeriods;
        [NullAllowed, Export("numberOfPeriods", ArgumentSemantic.Copy)]
        NSNumber NumberOfPeriods { get; }

        // @property (readonly, nonatomic) MobilePushMessageFrequencyUnit periodType;
        [Export("periodType")]
        MobilePushMessageFrequencyUnit PeriodType { get; }

        // @property (readonly, getter = isRollingPeriod, nonatomic) BOOL rollingPeriod;
        [Export("rollingPeriod")]
        bool RollingPeriod { [Bind("isRollingPeriod")] get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable subject;
        [NullAllowed, Export("subject")]
        string Subject { get; }

        // @property (readonly, copy, nonatomic) NSURL * _Nullable siteURL;
        [NullAllowed, Export("siteURL", ArgumentSemantic.Copy)]
        NSUrl SiteURL { get; }
    }

    // @interface ETEventRegion : NSObject
    [BaseType(typeof(NSObject))]
    interface ETEventRegion
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable fenceIdentifier;
        [NullAllowed, Export("fenceIdentifier")]
        string FenceIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable latitude;
        [NullAllowed, Export("latitude", ArgumentSemantic.Copy)]
        NSNumber Latitude { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable longitude;
        [NullAllowed, Export("longitude", ArgumentSemantic.Copy)]
        NSNumber Longitude { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable radius;
        [NullAllowed, Export("radius", ArgumentSemantic.Copy)]
        NSNumber Radius { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable proximityUUID;
        [NullAllowed, Export("proximityUUID")]
        string ProximityUUID { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable majorNumber;
        [NullAllowed, Export("majorNumber", ArgumentSemantic.Copy)]
        NSNumber MajorNumber { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable minorNumber;
        [NullAllowed, Export("minorNumber", ArgumentSemantic.Copy)]
        NSNumber MinorNumber { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable regionName;
        [NullAllowed, Export("regionName")]
        string RegionName { get; }

        // @property (readonly, nonatomic) BOOL isGeofenceRegion;
        [Export("isGeofenceRegion")]
        bool IsGeofenceRegion { get; }

        // @property (readonly, nonatomic) BOOL isBeaconRegion;
        [Export("isBeaconRegion")]
        bool IsBeaconRegion { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable messages;
        [NullAllowed, Export("messages", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] Messages { get; }
    }

    // @protocol ETGenericUpdateObjectProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ETGenericUpdateObjectProtocol
    {
        // @required +(instancetype _Nullable)alloc;
        //[Static, Abstract]
        //[Export("alloc")]
        //[return: NullAllowed]
        //ETGenericUpdateObjectProtocol Alloc();

        // @required -(instancetype _Nullable)initFromDictionary:(NSDictionary * _Nonnull)dict;
        //[Abstract]
        [Export("initFromDictionary:")]
        IntPtr Constructor(NSDictionary dict);

        // @required +(NSString * _Nullable)remoteRoutePath;
        // @optional -(void)setRemoteRoutePath:(NSString * _Nonnull)route;
        [Static, Abstract]
        [NullAllowed, Export("remoteRoutePath")]
        //[Verify(MethodToProperty)]
        string RemoteRoutePath { get; set; }

        //@required -(NSString * _Nonnull)remoteRoutePath;
        [Abstract]
        [Export("remoteRoutePath")]
        //[Verify(MethodToProperty)]
        string RemoteRoutePathMethod { get; }

        // @required +(NSString * _Nonnull)tableName;
        [Static, Abstract]
        [Export("tableName")]
        //[Verify(MethodToProperty)]
        string TableName { get; }

        // @required -(NSString * _Nonnull)tableName;
        [Abstract]
        [Export("tableName")]
        //[Verify(MethodToProperty)]
        string TableNameMethod { get; }

        // @required -(NSString * _Nonnull)jsonPayloadAsString;
        [Abstract]
        [Export("jsonPayloadAsString")]
        //[Verify(MethodToProperty)]
        string JsonPayloadAsString { get; }

        // @required -(NSDictionary * _Nonnull)jsonPayloadAsDictionary;
        [Abstract]
        [Export("jsonPayloadAsDictionary")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonPayloadAsDictionary { get; }

        // @required -(GenericUpdateSendMethod)sendMethod;
        [Abstract]
        [Export("sendMethod")]
        //[Verify(MethodToProperty)]
        GenericUpdateSendMethod SendMethod { get; }
    }

    // @interface ETGenericUpdate : NSObject
    [BaseType(typeof(NSObject))]
    interface ETGenericUpdate
    {
        // -(GenericUpdateSendMethod)sendMethod;
        [Export("sendMethod")]
        //[Verify(MethodToProperty)]
        GenericUpdateSendMethod SendMethod { get; }

        // -(NSString * _Nullable)remoteRoutePath;
        [NullAllowed, Export("remoteRoutePath")]
        //[Verify(MethodToProperty)]
        string RemoteRoutePath { get; }

        // -(NSString * _Nullable)jsonPayloadAsString;
        [NullAllowed, Export("jsonPayloadAsString")]
        //[Verify(MethodToProperty)]
        string JsonPayloadAsString { get; }

        // -(NSDictionary * _Nullable)jsonPayloadAsDictionary;
        [NullAllowed, Export("jsonPayloadAsDictionary")]
        //[Verify(MethodToProperty)]
        NSDictionary JsonPayloadAsDictionary { get; }

        // -(void)handleResponseWithSuccess;
        [Export("handleResponseWithSuccess")]
        void HandleResponseWithSuccess();

        // -(void)handleResponseWithFailure;
        [Export("handleResponseWithFailure")]
        void HandleResponseWithFailure();

        // -(BOOL)shouldSaveSelfToDatabase;
        [Export("shouldSaveSelfToDatabase")]
        //[Verify(MethodToProperty)]
        bool ShouldSaveSelfToDatabase { get; }

        // -(int)dbVersionNumber;
        [Export("dbVersionNumber")]
        //[Verify(MethodToProperty)]
        int DbVersionNumber { get; }

        // -(NSString * _Nonnull)databaseVersionKey;
        [Export("databaseVersionKey")]
        //[Verify(MethodToProperty)]
        string DatabaseVersionKey { get; }

        // -(BOOL)generatePersistentDataSchemaInDatabase;
        [Export("generatePersistentDataSchemaInDatabase")]
        //[Verify(MethodToProperty)]
        bool GeneratePersistentDataSchemaInDatabase { get; }

        // -(BOOL)updateSchemaInDatabase;
        [Export("updateSchemaInDatabase")]
        //[Verify(MethodToProperty)]
        bool UpdateSchemaInDatabase { get; }

        // -(NSArray * _Nullable)insertQueryArguments;
        [NullAllowed, Export("insertQueryArguments")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSObject[] InsertQueryArguments { get; }

        // -(NSArray * _Nullable)updateQueryArguments;
        [NullAllowed, Export("updateQueryArguments")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSObject[] UpdateQueryArguments { get; }

        // -(NSString * _Nullable)insertQuerySyntax;
        [NullAllowed, Export("insertQuerySyntax")]
        //[Verify(MethodToProperty)]
        string InsertQuerySyntax { get; }

        // -(NSString * _Nullable)updateQuerySyntax;
        [NullAllowed, Export("updateQuerySyntax")]
        //[Verify(MethodToProperty)]
        string UpdateQuerySyntax { get; }

        // -(BOOL)insertSelfIntoDatabase;
        [Export("insertSelfIntoDatabase")]
        //[Verify(MethodToProperty)]
        bool InsertSelfIntoDatabase { get; }

        // -(NSString * _Nonnull)tableName;
        [Export("tableName")]
        //[Verify(MethodToProperty)]
        string TableName { get; }

        // +(NSString * _Nonnull)tableName;
        [Static]
        [Export("tableName")]
        //[Verify(MethodToProperty)]
        string TableNameMethod { get; }

        // +(void)cleanupDatabaseRecords;
        [Static]
        [Export("cleanupDatabaseRecords")]
        void CleanupDatabaseRecords();

        // +(NSDateFormatter * _Nullable)formatterOfCorrectFormat;
        [Static]
        [NullAllowed, Export("formatterOfCorrectFormat")]
        //[Verify(MethodToProperty)]
        NSDateFormatter FormatterOfCorrectFormat { get; }

        // +(NSDateFormatter * _Nullable)alternativeFormatterOfCorrectFormat;
        [Static]
        [NullAllowed, Export("alternativeFormatterOfCorrectFormat")]
        //[Verify(MethodToProperty)]
        NSDateFormatter AlternativeFormatterOfCorrectFormat { get; }

        // +(NSDate * _Nullable)dateFromString:(NSString * _Nonnull)dateAsString;
        [Static]
        [Export("dateFromString:")]
        [return: NullAllowed]
        NSDate DateFromString(string dateAsString);

        // +(NSString * _Nullable)stringFromDate:(NSDate * _Nonnull)date;
        [Static]
        [Export("stringFromDate:")]
        [return: NullAllowed]
        string StringFromDate(NSDate date);

        // +(NSNumberFormatter * _Nullable)numberFormatterOfCorrectFormatForDouble;
        [Static]
        [NullAllowed, Export("numberFormatterOfCorrectFormatForDouble")]
        //[Verify(MethodToProperty)]
        NSNumberFormatter NumberFormatterOfCorrectFormatForDouble { get; }
    }

    // @interface ETLandingPagePresenter : UIViewController <UIWebViewDelegate>
    [BaseType(typeof(UIViewController))]
    interface ETLandingPagePresenter : IUIWebViewDelegate
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull landingPagePath;
        [Export("landingPagePath")]
        string LandingPagePath { get; }

        // -(instancetype _Nullable)initForLandingPageAt:(NSString * _Nonnull)landingPage;
        [Export("initForLandingPageAt:")]
        IntPtr Constructor(string landingPage);

        // -(instancetype _Nullable)initForLandingPageAtWithURL:(NSURL * _Nonnull)landingPage;
        [Export("initForLandingPageAtWithURL:")]
        IntPtr Constructor(NSUrl landingPage);
    }

    // @interface ETLocationManager : NSObject <CLLocationManagerDelegate>
    [BaseType(typeof(NSObject))]
    interface ETLocationManager : ICLLocationManagerDelegate
    {
        // @property (getter = isUpdatingGeofences, nonatomic) BOOL updatingGeofences;
        [Export("updatingGeofences")]
        bool UpdatingGeofences { [Bind("isUpdatingGeofences")] get; set; }

        // +(ETLocationManager * _Nonnull)locationManager __attribute__((deprecated("The locationManager method is deprecated. Please use sharedInstance instead.")));
        [Static]
        [Export("locationManager")]
        //[Verify(MethodToProperty)]
        ETLocationManager LocationManager { get; }

        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        ETLocationManager SharedInstance();

        // -(BOOL)locationEnabled;
        [Export("locationEnabled")]
        //[Verify(MethodToProperty)]
        bool LocationEnabled { get; }

        // -(void)startWatchingLocation;
        [Export("startWatchingLocation")]
        void StartWatchingLocation();

        // -(void)stopWatchingLocation;
        [Export("stopWatchingLocation")]
        void StopWatchingLocation();

        // -(void)appInForeground;
        [Export("appInForeground")]
        void AppInForeground();

        // -(void)appInBackground;
        [Export("appInBackground")]
        void AppInBackground();

        // -(void)updateLocationAndRetrieveMessages:(CLLocation * _Nonnull)loc forAppState:(LocationUpdateAppState)state;
        [Export("updateLocationAndRetrieveMessages:forAppState:")]
        void UpdateLocationAndRetrieveMessages(CLLocation loc, LocationUpdateAppState state);

        // -(void)monitorRegions:(NSSet<__kindof CLRegion *> * _Nonnull)fences ofRequestType:(ETRegionRequestType)requestType;
        [Export("monitorRegions:ofRequestType:")]
        void MonitorRegions(NSSet<CLRegion> fences, ETRegionRequestType requestType);

        // -(void)stopMonitoringRegions;
        [Export("stopMonitoringRegions")]
        void StopMonitoringRegions();

        // -(NSSet<__kindof CLRegion *> * _Nonnull)monitoredRegions;
        [Export("monitoredRegions")]
        //[Verify(MethodToProperty)]
        NSSet<CLRegion> MonitoredRegions { get; }

        // -(NSDictionary<NSString *,NSString *> * _Nonnull)lastKnownLocation;
        [Export("lastKnownLocation")]
        //[Verify(MethodToProperty)]
        NSDictionary<NSString, NSString> LastKnownLocation { get; }

        // -(BOOL)getWatchingLocation;
        [Export("getWatchingLocation")]
        //[Verify(MethodToProperty)]
        bool WatchingLocation { get; }
    }

    // @interface ETRegion : ETGenericUpdate
    [BaseType(typeof(ETGenericUpdate))]
    interface ETRegion
    {
        // @property (copy, nonatomic) NSString * _Nullable fenceIdentifier;
        [NullAllowed, Export("fenceIdentifier")]
        string FenceIdentifier { get; set; }

        // @property (copy, nonatomic) NSNumber * _Nullable latitude;
        [NullAllowed, Export("latitude", ArgumentSemantic.Copy)]
        NSNumber Latitude { get; set; }

        // @property (copy, nonatomic) NSNumber * _Nullable longitude;
        [NullAllowed, Export("longitude", ArgumentSemantic.Copy)]
        NSNumber Longitude { get; set; }

        // @property (copy, nonatomic) NSNumber * _Nullable radius;
        [NullAllowed, Export("radius", ArgumentSemantic.Copy)]
        NSNumber Radius { get; set; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable messages;
        [NullAllowed, Export("messages", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] Messages { get; }

        // @property (copy, nonatomic) NSString * _Nullable proximityUUID;
        [NullAllowed, Export("proximityUUID")]
        string ProximityUUID { get; set; }

        // @property (copy, nonatomic) NSNumber * _Nullable majorNumber;
        [NullAllowed, Export("majorNumber", ArgumentSemantic.Copy)]
        NSNumber MajorNumber { get; set; }

        // @property (copy, nonatomic) NSNumber * _Nullable minorNumber;
        [NullAllowed, Export("minorNumber", ArgumentSemantic.Copy)]
        NSNumber MinorNumber { get; set; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable entryCount;
        [NullAllowed, Export("entryCount", ArgumentSemantic.Copy)]
        NSNumber EntryCount { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable exitCount;
        [NullAllowed, Export("exitCount", ArgumentSemantic.Copy)]
        NSNumber ExitCount { get; }

        // @property (copy, nonatomic) NSString * _Nullable regionName;
        [NullAllowed, Export("regionName")]
        string RegionName { get; set; }

        // @property (assign, nonatomic) MobilePushGeofenceType locationType;
        [Export("locationType", ArgumentSemantic.Assign)]
        MobilePushGeofenceType LocationType { get; set; }

        // @property (nonatomic) ETRegionRequestType requestType;
        [Export("requestType", ArgumentSemantic.Assign)]
        ETRegionRequestType RequestType { get; set; }

        // -(instancetype _Nullable)initFromDictionary:(NSDictionary<__kindof NSString *,id> * _Nonnull)dict;
        [Export("initFromDictionary:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // -(BOOL)isEqualToRegion:(ETRegion * _Nonnull)region;
        [Export("isEqualToRegion:")]
        bool IsEqualToRegion(ETRegion region);

        // -(CLLocation * _Nullable)regionAsLocation;
        [NullAllowed, Export("regionAsLocation")]
        //[Verify(MethodToProperty)]
        CLLocation RegionAsLocation { get; }

        // -(CLRegion * _Nullable)regionAsCLRegion;
        [NullAllowed, Export("regionAsCLRegion")]
        //[Verify(MethodToProperty)]
        CLRegion RegionAsCLRegion { get; }

        // -(CLBeaconRegion * _Nullable)regionAsBeaconRegion;
        [NullAllowed, Export("regionAsBeaconRegion")]
        //[Verify(MethodToProperty)]
        CLBeaconRegion RegionAsBeaconRegion { get; }

        // -(BOOL)isGeofenceRegion;
        [Export("isGeofenceRegion")]
        //[Verify(MethodToProperty)]
        bool IsGeofenceRegion { get; }

        // -(BOOL)isBeaconRegion;
        [Export("isBeaconRegion")]
        //[Verify(MethodToProperty)]
        bool IsBeaconRegion { get; }

        // +(ETRegion * _Nullable)getRegionByIdentifier:(NSString * _Nonnull)identifier;
        [Static]
        [Export("getRegionByIdentifier:")]
        [return: NullAllowed]
        ETRegion GetRegionByIdentifier(string identifier);

        // +(ETRegion * _Nullable)getBeaconRegionForRegionWithProximityUUID:(NSString * _Nonnull)proximityUUID andMajorNumber:(NSNumber * _Nonnull)majorNumber andMinorNumber:(NSNumber * _Nonnull)minorNumber;
        [Static]
        [Export("getBeaconRegionForRegionWithProximityUUID:andMajorNumber:andMinorNumber:")]
        [return: NullAllowed]
        ETRegion GetBeaconRegionForRegionWithProximityUUID(string proximityUUID, NSNumber majorNumber, NSNumber minorNumber);

        // +(ETRegion * _Nullable)getBeaconRegionForRegionWithProximityUUID:(NSString * _Nonnull)proximityUUID;
        [Static]
        [Export("getBeaconRegionForRegionWithProximityUUID:")]
        [return: NullAllowed]
        ETRegion GetBeaconRegionForRegionWithProximityUUID(string proximityUUID);

        // +(NSSet<__kindof ETRegion *> * _Nullable)getFencesFromCache;
        [Static]
        [NullAllowed, Export("getFencesFromCache")]
        //[Verify(MethodToProperty)]
        NSSet FencesFromCache { get; }

        // +(NSSet<__kindof ETRegion *> * _Nullable)getFencesFromCacheIncludingInactive:(BOOL)getInactive;
        [Static]
        [Export("getFencesFromCacheIncludingInactive:")]
        [return: NullAllowed]
        NSSet GetFencesFromCacheIncludingInactive(bool getInactive);

        // +(BOOL)invalidateAllRegionsForRequestType:(ETRegionRequestType)requestType;
        [Static]
        [Export("invalidateAllRegionsForRequestType:")]
        bool InvalidateAllRegionsForRequestType(ETRegionRequestType requestType);

        // +(BOOL)invalidateAllRegions;
        [Static]
        [Export("invalidateAllRegions")]
        //[Verify(MethodToProperty)]
        bool InvalidateAllRegions { get; }

        // +(void)retrieveGeofencesFromET;
        [Static]
        [Export("retrieveGeofencesFromET")]
        void RetrieveGeofencesFromET();

        // +(void)retrieveProximityFromET;
        [Static]
        [Export("retrieveProximityFromET")]
        void RetrieveProximityFromET();

        // +(BOOL)generatePersistentDataSchemaInDatabase;
        [Static]
        [Export("generatePersistentDataSchemaInDatabase")]
        //[Verify(MethodToProperty)]
        bool GeneratePersistentDataSchemaInDatabase { get; }

        // -(ETEventRegion * _Nullable)regionAsETEventRegion;
        [NullAllowed, Export("regionAsETEventRegion")]
        //[Verify(MethodToProperty)]
        ETEventRegion RegionAsETEventRegion { get; }
    }

    // @interface ETMessage : ETGenericUpdate
    [BaseType(typeof(ETGenericUpdate))]
    interface ETMessage
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable messageIdentifier;
        [NullAllowed, Export("messageIdentifier")]
        string MessageIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable messageName;
        [NullAllowed, Export("messageName")]
        string MessageName { get; }

        // @property (readonly, nonatomic) MobilePushMessageType messageType;
        [Export("messageType")]
        MobilePushMessageType MessageType { get; }

        // @property (readonly, nonatomic) MobilePushContentType contentType;
        [Export("contentType")]
        MobilePushContentType ContentType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable alert;
        [NullAllowed, Export("alert")]
        string Alert { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable sound;
        [NullAllowed, Export("sound")]
        string Sound { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable badge;
        [NullAllowed, Export("badge")]
        string Badge { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable category;
        [NullAllowed, Export("category")]
        string Category { get; }

        // @property (readonly, copy, nonatomic) NSArray * _Nullable keyValuePairs;
        [NullAllowed, Export("keyValuePairs", ArgumentSemantic.Copy)]
        //[Verify(StronglyTypedNSArray)]
        NSObject[] KeyValuePairs { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable startDate;
        [NullAllowed, Export("startDate", ArgumentSemantic.Copy)]
        NSDate StartDate { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable endDate;
        [NullAllowed, Export("endDate", ArgumentSemantic.Copy)]
        NSDate EndDate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable siteIdentifier;
        [NullAllowed, Export("siteIdentifier")]
        string SiteIdentifier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable siteUrlAsString;
        [NullAllowed, Export("siteUrlAsString")]
        string SiteUrlAsString { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable openDirectPayload;
        [NullAllowed, Export("openDirectPayload")]
        string OpenDirectPayload { get; }

        // @property (readonly, nonatomic, strong) ETRegion * _Nullable relatedFence;
        [NullAllowed, Export("relatedFence", ArgumentSemantic.Strong)]
        ETRegion RelatedFence { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable messageLimit;
        [NullAllowed, Export("messageLimit", ArgumentSemantic.Copy)]
        NSNumber MessageLimit { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable messagesPerPeriod;
        [NullAllowed, Export("messagesPerPeriod", ArgumentSemantic.Copy)]
        NSNumber MessagesPerPeriod { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable numberOfPeriods;
        [NullAllowed, Export("numberOfPeriods", ArgumentSemantic.Copy)]
        NSNumber NumberOfPeriods { get; }

        // @property (readonly, nonatomic) MobilePushMessageFrequencyUnit periodType;
        [Export("periodType")]
        MobilePushMessageFrequencyUnit PeriodType { get; }

        // @property (readonly, getter = isRollingPeriod, nonatomic) BOOL rollingPeriod;
        [Export("rollingPeriod")]
        bool RollingPeriod { [Bind("isRollingPeriod")] get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable minTripped;
        [NullAllowed, Export("minTripped", ArgumentSemantic.Copy)]
        NSNumber MinTripped { get; }

        // @property (readonly, getter = isEphemeralMessage, nonatomic) BOOL ephemeralMessage;
        [Export("ephemeralMessage")]
        bool EphemeralMessage { [Bind("isEphemeralMessage")] get; }

        // @property (readonly, nonatomic) CLProximity proximity;
        [Export("proximity")]
        CLProximity Proximity { get; }

        // @property (readonly, nonatomic) NSInteger loiteringSeconds;
        [Export("loiteringSeconds")]
        nint LoiteringSeconds { get; }

        // @property (readonly, nonatomic) BOOL read;
        [Export("read")]
        bool Read { get; }

        // @property (readonly, nonatomic) BOOL active;
        [Export("active")]
        bool Active { get; }

        // @property (copy, nonatomic) NSString * _Nullable notificationID;
        [NullAllowed, Export("notificationID")]
        string NotificationID { get; set; }

        // @property (readonly, nonatomic) BOOL hasShownForBeacon;
        [Export("hasShownForBeacon")]
        bool HasShownForBeacon { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable requestId;
        [NullAllowed, Export("requestId")]
        string RequestId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable messageHash;
        [NullAllowed, Export("messageHash")]
        string MessageHash { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nullable statusDirty;
        [NullAllowed, Export("statusDirty", ArgumentSemantic.Copy)]
        NSNumber StatusDirty { get; }

        // -(instancetype _Nullable)initFromDictionary:(NSDictionary<__kindof NSString *,id> * _Nonnull)dict;
        [Export("initFromDictionary:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict);

        // -(instancetype _Nullable)initFromDictionary:(NSDictionary<__kindof NSString *,id> * _Nonnull)dict forFence:(ETRegion * _Nullable)region;
        [Export("initFromDictionary:forFence:")]
        IntPtr Constructor(NSDictionary<NSString, NSObject> dict, [NullAllowed] ETRegion region);

        // -(NSString * _Nullable)subject;
        [NullAllowed, Export("subject")]
        //[Verify(MethodToProperty)]
        string Subject { get; }

        // -(NSURL * _Nullable)siteURL;
        [NullAllowed, Export("siteURL")]
        //[Verify(MethodToProperty)]
        NSUrl SiteURL { get; }

        // -(BOOL)messageScheduledForDisplay;
        [Export("messageScheduledForDisplay")]
        //[Verify(MethodToProperty)]
        bool MessageScheduledForDisplay { get; }

        // -(NSDate * _Nullable)getLastShownDate;
        [NullAllowed, Export("getLastShownDate")]
        //[Verify(MethodToProperty)]
        NSDate LastShownDate { get; }

        // -(int)getShowCount;
        [Export("getShowCount")]
        //[Verify(MethodToProperty)]
        int ShowCount { get; }

        // +(NSArray * _Nullable)getCloudPageMessages;
        [Static]
        [NullAllowed, Export("getCloudPageMessages")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSObject[] CloudPageMessages { get; }

        // +(NSInteger)getReadMessageCount;
        [Static]
        [Export("getReadMessageCount")]
        //[Verify(MethodToProperty)]
        nint ReadMessageCount { get; }

        // +(NSInteger)getUnreadMessageCount;
        [Static]
        [Export("getUnreadMessageCount")]
        //[Verify(MethodToProperty)]
        nint UnreadMessageCount { get; }

        // +(NSInteger)getMessageCount;
        [Static]
        [Export("getMessageCount")]
        //[Verify(MethodToProperty)]
        nint MessageCount { get; }

        // +(void)markAllAsRead;
        [Static]
        [Export("markAllAsRead")]
        void MarkAllAsRead();

        // -(BOOL)markAsRead;
        [Export("markAsRead")]
        //[Verify(MethodToProperty)]
        bool MarkAsRead { get; }

        // -(BOOL)markAsDeleted;
        [Export("markAsDeleted")]
        //[Verify(MethodToProperty)]
        bool MarkAsDeleted { get; }

        // +(void)trackInboxMessageOpened:(ETCloudPage * _Nonnull)cloudPageInboxMessage;
        [Static]
        [Export("trackInboxMessageOpened:")]
        void TrackInboxMessageOpened(ETCloudPage cloudPageInboxMessage);

        // +(NSArray<__kindof ETMessage *> * _Nullable)getMessagesByContentType:(MobilePushContentType)contentType;
        [Static]
        [Export("getMessagesByContentType:")]
        [return: NullAllowed]
        ETMessage[] GetMessagesByContentType(MobilePushContentType contentType);

        // +(ETMessage * _Nullable)getMessageByIdentifier:(NSString * _Nonnull)identifier;
        [Static]
        [Export("getMessageByIdentifier:")]
        [return: NullAllowed]
        ETMessage GetMessageByIdentifier(string identifier);

        // +(NSArray<__kindof ETMessage *> * _Nullable)getMessagesByType:(MobilePushMessageType)type;
        [Static]
        [Export("getMessagesByType:")]
        [return: NullAllowed]
        ETMessage[] GetMessagesByType(MobilePushMessageType type);

        // +(NSArray<__kindof ETMessage *> * _Nullable)getMessagesForGeofence:(ETRegion * _Nonnull)fence;
        [Static]
        [Export("getMessagesForGeofence:")]
        [return: NullAllowed]
        ETMessage[] GetMessagesForGeofence(ETRegion fence);

        // +(NSArray<__kindof ETMessage *> * _Nullable)getMessagesForGeofence:(ETRegion * _Nonnull)fence andMessageType:(MobilePushMessageType)type;
        [Static]
        [Export("getMessagesForGeofence:andMessageType:")]
        [return: NullAllowed]
        ETMessage[] GetMessagesForGeofence(ETRegion fence, MobilePushMessageType type);

        // +(NSArray<__kindof ETMessage *> * _Nullable)getProximityMessagesForRegion:(ETRegion * _Nonnull)region;
        [Static]
        [Export("getProximityMessagesForRegion:")]
        [return: NullAllowed]
        ETMessage[] GetProximityMessagesForRegion(ETRegion region);

        // +(void)getMessagesFromExactTargetOfMessageType:(MobilePushMessageType)messageType andContentType:(MobilePushContentType)contentType;
        [Static]
        [Export("getMessagesFromExactTargetOfMessageType:andContentType:")]
        void GetMessagesFromExactTargetOfMessageType(MobilePushMessageType messageType, MobilePushContentType contentType);

        // +(BOOL)invalidateAllMessagesForType:(MobilePushMessageType)type;
        [Static]
        [Export("invalidateAllMessagesForType:")]
        bool InvalidateAllMessagesForType(MobilePushMessageType type);

        // +(BOOL)invalidateAllMessagesForContentType:(MobilePushContentType)type;
        [Static]
        [Export("invalidateAllMessagesForContentType:")]
        bool InvalidateAllMessagesForContentType(MobilePushContentType type);

        // -(BOOL)isEqualToMessage:(ETMessage * _Nonnull)message;
        [Export("isEqualToMessage:")]
        bool IsEqualToMessage(ETMessage message);

        // -(ETEventMessage * _Nullable)messageAsETEventMessage;
        [NullAllowed, Export("messageAsETEventMessage")]
        //[Verify(MethodToProperty)]
        ETEventMessage MessageAsETEventMessage { get; }

        // -(ETCloudPage * _Nullable)messageAsETCloudPage;
        [NullAllowed, Export("messageAsETCloudPage")]
        //[Verify(MethodToProperty)]
        ETCloudPage MessageAsETCloudPage { get; }
    }

    // @protocol ExactTargetOpenDirectDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ExactTargetOpenDirectDelegate
    {
        // @required -(void)didReceiveOpenDirectMessageWithContents:(NSString * _Nonnull)payload;
        [Abstract]
        [Export("didReceiveOpenDirectMessageWithContents:")]
        void DidReceiveOpenDirectMessageWithContents(string payload);

        // @optional -(BOOL)shouldDeliverOpenDirectMessageIfAppIsRunning;
        [Export("shouldDeliverOpenDirectMessageIfAppIsRunning")]
        //[Verify(MethodToProperty)]
        bool ShouldDeliverOpenDirectMessageIfAppIsRunning { get; }
    }

    // @protocol ExactTargetCloudPageWithAlertDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ExactTargetCloudPageWithAlertDelegate
    {
        // @required -(void)didReceiveCloudPageWithAlertMessageWithContents:(NSString * _Nonnull)payload;
        [Abstract]
        [Export("didReceiveCloudPageWithAlertMessageWithContents:")]
        void DidReceiveCloudPageWithAlertMessageWithContents(string payload);

        // @optional -(BOOL)shouldDeliverCloudPageWithAlertMessageIfAppIsRunning;
        [Export("shouldDeliverCloudPageWithAlertMessageIfAppIsRunning")]
        //[Verify(MethodToProperty)]
        bool ShouldDeliverCloudPageWithAlertMessageIfAppIsRunning { get; }
    }

    // @interface ETPush : NSObject
    [BaseType(typeof(NSObject))]
    interface ETPush
    {
        // +(instancetype _Nullable)pushManager;
        [Static]
        [Export("pushManager")]
        [return: NullAllowed]
        ETPush PushManager();

        // -(BOOL)configureSDKWithAppID:(NSString * _Nonnull)etAppID andAccessToken:(NSString * _Nonnull)accessToken withAnalytics:(BOOL)analyticsState andLocationServices:(BOOL)locState andProximityServices:(BOOL)proximityState andCloudPages:(BOOL)cpState withPIAnalytics:(BOOL)pIAnalyticsState error:(NSError * _Nullable * _Nullable)configureError;
        [Export("configureSDKWithAppID:andAccessToken:withAnalytics:andLocationServices:andProximityServices:andCloudPages:withPIAnalytics:error:")]
        bool ConfigureSDKWithAppID(string etAppID, string accessToken, bool analyticsState, bool locState, bool proximityState, bool cpState, bool pIAnalyticsState, [NullAllowed] out NSError configureError);

        // -(BOOL)shouldShowLocalAlert;
        [Export("shouldShowLocalAlert")]
        //[Verify(MethodToProperty)]
        bool ShouldShowLocalAlert { get; }

        // -(id<ExactTargetOpenDirectDelegate> _Nullable)openDirectDelegate;
        // -(void)setOpenDirectDelegate:(id<ExactTargetOpenDirectDelegate> _Nullable)delegate;
        [NullAllowed, Export("openDirectDelegate")]
        //[Verify(MethodToProperty)]
        ExactTargetOpenDirectDelegate OpenDirectDelegate { get; set; }

        // -(id<ExactTargetCloudPageWithAlertDelegate> _Nullable)cloudPageWithAlertDelegate;
        // -(void)setCloudPageWithAlertDelegate:(id<ExactTargetCloudPageWithAlertDelegate> _Nullable)delegate;
        [NullAllowed, Export("cloudPageWithAlertDelegate")]
        //[Verify(MethodToProperty)]
        ExactTargetCloudPageWithAlertDelegate CloudPageWithAlertDelegate { get; set; }

        // -(void)updateET;
        [Export("updateET")]
        void UpdateET();

        // -(void)registerForRemoteNotificationsWithDelegate:(id<UNUserNotificationCenterDelegate> _Nullable)delegate options:(UNAuthorizationOptions)options categories:(NSSet<UNNotificationCategory *> * _Nullable)categories completionHandler:(void (^ _Nonnull)(BOOL, NSError * _Nullable))completionHandler;
        [Export("registerForRemoteNotificationsWithDelegate:options:categories:completionHandler:")]
        void RegisterForRemoteNotificationsWithDelegate([NullAllowed] UNUserNotificationCenterDelegate @delegate, UNAuthorizationOptions options, [NullAllowed] NSSet<UNNotificationCategory> categories, Action<bool, NSError> completionHandler);

        // -(void)registeredForRemoteNotificationsWithCompletionHandler:(void (^ _Nonnull)(BOOL, UNAuthorizationOptions))completionHandler;
        [Export("registeredForRemoteNotificationsWithCompletionHandler:")]
        void RegisteredForRemoteNotificationsWithCompletionHandler(Action<bool, UNAuthorizationOptions> completionHandler);

        // -(void)currentUserNotificationSettingsWithCompletionHandler:(void (^ _Nonnull)(UNNotificationSettings * _Nonnull))completionHandler;
        [Export("currentUserNotificationSettingsWithCompletionHandler:")]
        void CurrentUserNotificationSettingsWithCompletionHandler(Action<UNNotificationSettings> completionHandler);

        // -(void)setUserNotificationCenterDelegate:(id<UNUserNotificationCenterDelegate> _Nullable)delegate;
        [Export("setUserNotificationCenterDelegate:")]
        void SetUserNotificationCenterDelegate([NullAllowed] UNUserNotificationCenterDelegate @delegate);

        // -(void)setUserNotificationCenterCategories:(NSSet<UNNotificationCategory *> * _Nullable)categories;
        [Export("setUserNotificationCenterCategories:")]
        void SetUserNotificationCenterCategories([NullAllowed] NSSet<UNNotificationCategory> categories);

        // -(void)getUserNotificationCenterCategoriesWithCompletionHandler:(void (^ _Nonnull)(NSSet<UNNotificationCategory *> * _Nonnull))completionHandler;
        [Export("getUserNotificationCenterCategoriesWithCompletionHandler:")]
        void GetUserNotificationCenterCategoriesWithCompletionHandler(Action<NSSet<UNNotificationCategory>> completionHandler);

        // -(void)addNotificationRequest:(UNNotificationRequest * _Nonnull)request withCompletionHandler:(void (^ _Nullable)(NSError * _Nullable))completionHandler;
        [Export("addNotificationRequest:withCompletionHandler:")]
        void AddNotificationRequest(UNNotificationRequest request, [NullAllowed] Action<NSError> completionHandler);

        // -(void)getPendingNotificationRequestsWithCompletionHandler:(void (^ _Nonnull)(NSArray<UNNotificationRequest *> * _Nonnull))completionHandler;
        [Export("getPendingNotificationRequestsWithCompletionHandler:")]
        void GetPendingNotificationRequestsWithCompletionHandler(Action<NSArray<UNNotificationRequest>> completionHandler);

        // -(void)removePendingNotificationRequestsWithIdentifiers:(NSArray<NSString *> * _Nonnull)identifiers;
        [Export("removePendingNotificationRequestsWithIdentifiers:")]
        void RemovePendingNotificationRequestsWithIdentifiers(string[] identifiers);

        // -(void)removeAllPendingNotificationRequests;
        [Export("removeAllPendingNotificationRequests")]
        void RemoveAllPendingNotificationRequests();

        // -(void)getDeliveredNotificationsWithCompletionHandler:(void (^ _Nonnull)(NSArray<UNNotification *> * _Nonnull))completionHandler;
        [Export("getDeliveredNotificationsWithCompletionHandler:")]
        void GetDeliveredNotificationsWithCompletionHandler(Action<NSArray<UNNotification>> completionHandler);

        // -(void)removeDeliveredNotificationsWithIdentifiers:(NSArray<NSString *> * _Nonnull)identifiers;
        [Export("removeDeliveredNotificationsWithIdentifiers:")]
        void RemoveDeliveredNotificationsWithIdentifiers(string[] identifiers);

        // -(void)removeAllDeliveredNotifications;
        [Export("removeAllDeliveredNotifications")]
        void RemoveAllDeliveredNotifications();

        // -(void)registerForRemoteNotifications;
        [Export("registerForRemoteNotifications")]
        void RegisterForRemoteNotifications();

        // -(BOOL)isRegisteredForRemoteNotifications;
        [Export("isRegisteredForRemoteNotifications")]
        //[Verify(MethodToProperty)]
        bool IsRegisteredForRemoteNotifications { get; }

        // -(void)registerUserNotificationSettings:(UIUserNotificationSettings * _Nonnull)notificationSettings;
        [Export("registerUserNotificationSettings:")]
        void RegisterUserNotificationSettings(UIUserNotificationSettings notificationSettings);

        // -(UIUserNotificationSettings * _Nonnull)currentUserNotificationSettings;
        [Export("currentUserNotificationSettings")]
        //[Verify(MethodToProperty)]
        UIUserNotificationSettings CurrentUserNotificationSettings { get; }

        // -(void)didRegisterUserNotificationSettings:(UIUserNotificationSettings * _Nonnull)notificationSettings;
        [Export("didRegisterUserNotificationSettings:")]
        void DidRegisterUserNotificationSettings(UIUserNotificationSettings notificationSettings);

        // -(void)registerDeviceToken:(NSData * _Nonnull)deviceToken;
        [Export("registerDeviceToken:")]
        void RegisterDeviceToken(NSData deviceToken);

        // -(NSString * _Nullable)deviceToken;
        [NullAllowed, Export("deviceToken")]
        //[Verify(MethodToProperty)]
        string DeviceToken { get; }

        // -(void)applicationDidFailToRegisterForRemoteNotificationsWithError:(NSError * _Nonnull)error;
        [Export("applicationDidFailToRegisterForRemoteNotificationsWithError:")]
        void ApplicationDidFailToRegisterForRemoteNotificationsWithError(NSError error);

        // -(void)shouldDisplayAlertViewIfPushReceived:(BOOL)desiredState;
        [Export("shouldDisplayAlertViewIfPushReceived:")]
        void ShouldDisplayAlertViewIfPushReceived(bool desiredState);

        // -(void)applicationLaunchedWithOptions:(NSDictionary * _Nullable)launchOptions;
        [Export("applicationLaunchedWithOptions:")]
        void ApplicationLaunchedWithOptions([NullAllowed] NSDictionary launchOptions);

        // -(void)applicationTerminated;
        [Export("applicationTerminated")]
        void ApplicationTerminated();

        // -(void)handleNotification:(NSDictionary * _Nonnull)userInfo forApplicationState:(UIApplicationState)applicationState;
        [Export("handleNotification:forApplicationState:")]
        void HandleNotification(NSDictionary userInfo, UIApplicationState applicationState);

        // -(void)handleRemoteNotification:(NSDictionary * _Nullable)userInfo;
        [Export("handleRemoteNotification:")]
        void HandleRemoteNotification([NullAllowed] NSDictionary userInfo);

        // -(void)handleLocalNotification:(UILocalNotification * _Nullable)localNotification;
        [Export("handleLocalNotification:")]
        void HandleLocalNotification([NullAllowed] UILocalNotification localNotification);

        // -(void)handleUserNotificationResponse:(UNNotificationResponse * _Nullable)notificationResponse;
        [Export("handleUserNotificationResponse:")]
        void HandleUserNotificationResponse([NullAllowed] UNNotificationResponse notificationResponse);

        // -(BOOL)setSubscriberKey:(NSString * _Nonnull)subscriberKey;
        [Export("setSubscriberKey:")]
        bool SetSubscriberKey(string subscriberKey);

        // -(NSString * _Nullable)getSubscriberKey;
        [NullAllowed, Export("getSubscriberKey")]
        //[Verify(MethodToProperty)]
        string SubscriberKey { get; }

        // -(BOOL)addTag:(NSString * _Nonnull)tag;
        [Export("addTag:")]
        bool AddTag(string tag);

        // -(NSString * _Nullable)removeTag:(NSString * _Nonnull)tag;
        [Export("removeTag:")]
        [return: NullAllowed]
        string RemoveTag(string tag);

        // -(NSSet * _Nonnull)allTags __attribute__((deprecated("allTags is deprecated. Please use getTags instead.")));
        [Export("allTags")]
        //[Verify(MethodToProperty)]
        NSSet AllTags { get; }

        // -(NSSet * _Nonnull)getTags;
        [Export("getTags")]
        //[Verify(MethodToProperty)]
        NSSet Tags { get; }

        // -(BOOL)addAttributeNamed:(NSString * _Nonnull)name value:(NSString * _Nonnull)value;
        [Export("addAttributeNamed:value:")]
        bool AddAttributeNamed(string name, string value);

        // -(NSString * _Nullable)removeAttributeNamed:(NSString * _Nonnull)name;
        [Export("removeAttributeNamed:")]
        [return: NullAllowed]
        string RemoveAttributeNamed(string name);

        // -(NSDictionary * _Nonnull)allAttributes __attribute__((deprecated("allAttributes has been deprecated. Please use getAttributes instead")));
        [Export("allAttributes")]
        //[Verify(MethodToProperty)]
        NSDictionary AllAttributes { get; }

        // -(NSDictionary * _Nonnull)getAttributes;
        [Export("getAttributes")]
        //[Verify(MethodToProperty)]
        NSDictionary Attributes { get; }

        // -(void)startListeningForApplicationNotifications;
        [Export("startListeningForApplicationNotifications")]
        void StartListeningForApplicationNotifications();

        // -(void)stopListeningForApplicationNotifications;
        [Export("stopListeningForApplicationNotifications")]
        void StopListeningForApplicationNotifications();

        // -(void)applicationDidBecomeActiveNotificationReceived;
        [Export("applicationDidBecomeActiveNotificationReceived")]
        void ApplicationDidBecomeActiveNotificationReceived();

        // -(void)applicationDidEnterBackgroundNotificationReceived;
        [Export("applicationDidEnterBackgroundNotificationReceived")]
        void ApplicationDidEnterBackgroundNotificationReceived();

        // +(NSString * _Nonnull)safeDeviceIdentifier;
        [Static]
        [Export("safeDeviceIdentifier")]
        //[Verify(MethodToProperty)]
        string SafeDeviceIdentifier { get; }

        // +(NSString * _Nonnull)hardwareIdentifier;
        [Static]
        [Export("hardwareIdentifier")]
        //[Verify(MethodToProperty)]
        string HardwareIdentifier { get; }

        // +(BOOL)isPushEnabled;
        [Static]
        [Export("isPushEnabled")]
        //[Verify(MethodToProperty)]
        bool IsPushEnabled { get; }

        // +(NSString * _Nonnull)getSDKVersionName;
        [Static]
        [Export("getSDKVersionName")]
        //[Verify(MethodToProperty)]
        string SDKVersionName { get; }

        // +(NSString * _Nonnull)getSDKVersionCode;
        [Static]
        [Export("getSDKVersionCode")]
        //[Verify(MethodToProperty)]
        string SDKVersionCode { get; }

        // +(void)setETLoggerToRequiredState:(BOOL)state;
        [Static]
        [Export("setETLoggerToRequiredState:")]
        void SetETLoggerToRequiredState(bool state);

        // +(void)setLoggerWithHandler:(void (^ _Nullable)(NSString * _Nonnull))customLogger;
        [Static]
        [Export("setLoggerWithHandler:")]
        void SetLoggerWithHandler([NullAllowed] Action<NSString> customLogger);

        // +(NSString * _Nullable)getSDKState;
        [Static]
        [NullAllowed, Export("getSDKState")]
        //[Verify(MethodToProperty)]
        string SDKState { get; }

        // -(BOOL)refreshWithFetchCompletionHandler:(void (^ _Nullable)(UIBackgroundFetchResult))completionHandler;
        [Export("refreshWithFetchCompletionHandler:")]
        bool RefreshWithFetchCompletionHandler([NullAllowed] Action<UIBackgroundFetchResult> completionHandler);

        // +(NSArray * _Nonnull)getCloudPages;
        [Static]
        [Export("getCloudPages")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSObject[] CloudPages { get; }
    }

    // @interface ETWKLandingPagePresenter : UIViewController <WKNavigationDelegate>
    [BaseType(typeof(UIViewController))]
    interface ETWKLandingPagePresenter : IWKNavigationDelegate
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull landingPagePath;
        [Export("landingPagePath")]
        string LandingPagePath { get; }

        // -(instancetype _Nullable)initForLandingPageAt:(NSString * _Nonnull)landingPage;
        [Export("initForLandingPageAt:")]
        IntPtr Constructor(string landingPage);

        // -(instancetype _Nullable)initForLandingPageAtWithURL:(NSURL * _Nonnull)landingPage;
        [Export("initForLandingPageAtWithURL:")]
        IntPtr Constructor(NSUrl landingPage);
    }

    // @interface ExactTargetEnhancedPushDataSource : NSObject <UITableViewDataSource>
    [BaseType(typeof(NSObject))]
    interface ExactTargetEnhancedPushDataSource : IUITableViewDataSource
    {
        // @property (readonly, copy, nonatomic) NSArray<__kindof ETMessage *> * _Nullable messages;
        [NullAllowed, Export("messages", ArgumentSemantic.Copy)]
        ETMessage[] Messages { get; }

        // @property (nonatomic, weak) UITableView * _Nullable inboxTableView;
        [NullAllowed, Export("inboxTableView", ArgumentSemantic.Weak)]
        UITableView InboxTableView { get; set; }
    }

    // @interface PICart : NSObject <NSCoding, NSCopying>
    [BaseType(typeof(NSObject))]
    interface PICart : INSCoding, INSCopying
    {
        // -(instancetype _Nonnull)initWithCartItems:(NSArray * _Nonnull)cartItems __attribute__((objc_designated_initializer));
        [Export("initWithCartItems:")]
        [DesignatedInitializer]
        //[Verify(StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] cartItems);

        // -(NSDictionary * _Nonnull)dictionaryRepresentation;
        [Export("dictionaryRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary DictionaryRepresentation { get; }
    }

    // @interface PICartItem : NSObject <NSCoding, NSCopying>
    [BaseType(typeof(NSObject))]
    interface PICartItem : INSCoding, INSCopying
    {
        // -(instancetype _Nonnull)initWithPrice:(NSNumber * _Nonnull)price quantity:(NSNumber * _Nonnull)quantity item:(NSString * _Nonnull)item;
        [Export("initWithPrice:quantity:item:")]
        IntPtr Constructor(NSNumber price, NSNumber quantity, string item);

        // -(instancetype _Nonnull)initWithPrice:(NSNumber * _Nonnull)price quantity:(NSNumber * _Nonnull)quantity item:(NSString * _Nonnull)item uniqueId:(NSString * _Nonnull)uniqueId;
        [Export("initWithPrice:quantity:item:uniqueId:")]
        IntPtr Constructor(NSNumber price, NSNumber quantity, string item, string uniqueId);

        // -(NSDictionary * _Nonnull)dictionaryRepresentation;
        [Export("dictionaryRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary DictionaryRepresentation { get; }
    }

    // @interface PIOrder : NSObject <NSCoding, NSCopying>
    [BaseType(typeof(NSObject))]
    interface PIOrder : INSCoding, INSCopying
    {
        // -(instancetype _Nonnull)initWithOrderNumber:(NSString * _Nonnull)orderNumber shipping:(NSNumber * _Nonnull)shipping discount:(NSNumber * _Nonnull)discount cart:(PICart * _Nonnull)cart __attribute__((objc_designated_initializer));
        [Export("initWithOrderNumber:shipping:discount:cart:")]
        [DesignatedInitializer]
        IntPtr Constructor(string orderNumber, NSNumber shipping, NSNumber discount, PICart cart);

        // -(NSDictionary * _Nonnull)dictionaryRepresentation;
        [Export("dictionaryRepresentation")]
        //[Verify(MethodToProperty)]
        NSDictionary DictionaryRepresentation { get; }
    }
    // The first step to creating a binding is to add your native library ("libNativeLibrary.a")
    // to the project by right-clicking (or Control-clicking) the folder containing this source
    // file and clicking "Add files..." and then simply select the native library (or libraries)
    // that you want to bind.
    //
    // When you do that, you'll notice that MonoDevelop generates a code-behind file for each
    // native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
    // architectures that the native library supports and fills in that information for you,
    // however, it cannot auto-detect any Frameworks or other system libraries that the
    // native library may depend on, so you'll need to fill in that information yourself.
    //
    // Once you've done that, you're ready to move on to binding the API...
    //
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, int index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     IntPtr Constructor (ElmoMuppet elmo);
    //
    // For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
    //
}
