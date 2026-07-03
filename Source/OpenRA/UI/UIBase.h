// UITheme.h
#pragma once
#include <string>

namespace UITheme {
    const std::string PrimaryBlue = "#00A3FF";
    const std::string DarkBase = "#050A0F";
    const std::string PanelSurface = "#101E2D";
    const std::string TextPrimary = "#E0F0FF";
    const float GlassOpacity = 0.85f;
    const float BlurRadius = 20.0f;
}

// Base UI Component
class UIBaseComponent {
public:
    virtual void Draw() = 0;
    virtual ~UIBaseComponent() = default;
};

// Panel implementation with Blue Glassmorphism
class BluePanel : public UIBaseComponent {
public:
    void Draw() override {
        // Implementation: Set style to UITheme::PanelSurface, 
        // Apply Gaussian Blur (UITheme::BlurRadius),
        // Draw 1px Border (UITheme::PrimaryBlue)
    }
};
