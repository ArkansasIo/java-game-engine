// LayoutEditor.h
#pragma once
#include "UIBase.h"
#include <vector>

struct UIWidget {
    std::string id;
    float x, y, width, height;
};

class LayoutEditor {
private:
    std::vector<UIWidget> activeWidgets;
    bool isEditing = false;

public:
    void ToggleEditMode() { isEditing = !isEditing; }
    
    // Allows dragging components if isEditing is true
    void HandleInput(float mouseX, float mouseY);
    
    // Save current layout to JSON
    void ExportLayout(const std::string& path);
};
