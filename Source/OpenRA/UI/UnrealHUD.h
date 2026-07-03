// UnrealHUD.h
#pragma once
#include "CoreMinimal.h"
#include "Blueprint/UserWidget.h"
#include "UnrealHUD.generated.h"

UCLASS()
class UBlueHUDWidget : public UUserWidget {
    GENERATED_BODY()
public:
    // Blueprint callable functions to map to our C++ HUDManager
    UFUNCTION(BlueprintCallable, Category = "HUD")
    void ExecuteCommand(FString CommandID);
    
    UPROPERTY(meta = (BindWidget))
    class UImage* BackgroundGlass;
};
