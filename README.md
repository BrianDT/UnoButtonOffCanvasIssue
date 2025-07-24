# UnoButtonOffCanvasIssue
Reported to Uno Platform as issue #12702: [Android, iOS] Buttons positioned off canvas not firing

On Android and iOS if a button is positioned beyond the boundaries of a Canvas with a negative Canvas.Top or negative Canvas.Left value, then the button will not fire it’s click handler (or it’s Command)
This is not an issue for Windows or WASM.

Button click event should still be actioned regardless of position.

Reproduced by solution in repository https://github.com/BrianDT/UnoButtonOffCanvasIssue

Workaround
Re-architect the projects UI structure so that buttons are parented differently

Updated to Uno 6.1.23 with SkiaRenderer
#12702 Confirmed resolved
