// HUDManager.cpp
#include "Systems.h"
#include "UIBase.h"
#include "InputDelegates.h"
#include <iostream>

class HUDManager {
public:
    void Init() {
        std::cout << "Initializing Blue HUD Interface..." << std::endl;
        
        // Registering Action Callbacks mapped to actual Systems
        InputDispatcher::RegisterAction("CMD_MOVE", []() { FleetSystem::Move(); });
        InputDispatcher::RegisterAction("CMD_ATTACK", []() { FleetSystem::Attack(); });
        InputDispatcher::RegisterAction("CMD_BUILD", []() { PlanetSystem::Build(); });
    }

    void Render() {
        std::cout << "HUD Rendered with Blue Glassmorphism." << std::endl;
    }
};
