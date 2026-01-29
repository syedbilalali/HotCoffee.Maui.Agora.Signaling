#!/bin/bash
set -e

# -------- Config --------
LIB_NAME="AgoraSignaling"
NAMESPACE="HotCoffee.Maui.Agora.Signaling.iOS"
FRAMEWORK_PATH="../src/ios/native/libs/AgoraRtmKit.xcframework"
OUTPUT_PATH="../build/bindings/ios"
SDK="iphoneos"

XCFRAMEWORK_PATH="../src/ios/native/libs/AgoraRtmKit.xcframework"
SLICE="ios-arm64_armv7"
FRAMEWORK_NAME="AgoraRtmKit"

HEADERS_PATH="$XCFRAMEWORK_PATH/$SLICE/$FRAMEWORK_NAME.framework/Headers"
# ------------------------

echo "🔧 Generating iOS bindings for $LIB_NAME"

if [ ! -d "$FRAMEWORK_PATH" ]; then
  echo "❌ Framework not found: $FRAMEWORK_PATH"
  exit 1
fi

mkdir -p "$OUTPUT_PATH"
echo "Headers Path " +  $HEADERS_PATH

sharpie bind \
  -sdk $SDK \
  -namespace $NAMESPACE \
  -scope "$HEADERS_PATH" \
  "$HEADERS_PATH/AgoraRtmKit.h" \
  -o $OUTPUT_PATH
  
echo "✅ Bindings generated at $OUTPUT_PATH"