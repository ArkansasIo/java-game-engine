// UnrealHUD.cpp
#include "UnrealHUD.h"
#include "Systems/InputDelegates.h"
#include "Components/Image.h"

void UBlueHUDWidget::ExecuteCommand(FString CommandID) {
    // Bridges the UI button click to our central InputDispatcher
    InputDispatcher::Execute(TCHAR_TO_UTF8(*CommandID));
}
