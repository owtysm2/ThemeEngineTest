> [!CAUTION]
> (in-dev and not recommended for prod use, at all)

**This is rather a proof-of-concept**, and this had most definitely been done before.<br>

---
# 📃 The Overview
This project aims to provide designer-driven theming(*-ish?*) capabilities for WinForms.<br>
You can define themes with the `Theme Definer` component. Then, give the theme a name, mark which controls to affect, pick what properties to change and to what values.

## Quick Explanation
`Themes` can be shared across forms, as when your form opens, its themes report themselves to the `Internal Theme Manager` class.<br>
A `Theme` is an object created by the `Theme Definer`. It contains the theme's name, alongside the info on what controls and/or properties to change.

> [!NOTE]
> Every `Theme` is serialized in your Form's resources, so that it persists.<br>
> The `Theme` will only be accessible to other forms, if its parent form had already been shown.

### In short
Create at design-time, load at run-time:
- Each theme is created with a `Theme Definer`
- Each theme gets assigned a name and a list of types (or individual controls) to affect
- Each type (or individual control) gets assigned a list of properties to change.

<img width="1603" height="909" alt="image" src="https://github.com/user-attachments/assets/d4e2784b-519f-4303-b9cb-eda59e9fd0f8" />

# 🚧 Important Notes
> [!WARNING]
> If you want to use a theme across Forms, the `Theme`'s parent Form (to which it was added) needs to have been shown at least once.

> [!NOTE]
> Dynamically created controls need to have the theme applied manually after creation:
> ```cs
> Button newButton = new Button();
> newButton.Size = new Size(128, 32);
>
> theme_Definer1.ApplyTo(newButton); // apply theme to singular control
> Controls.Add(newButton);
> ```
> ... or you can add many controls and apply the theme to their `Parent`:
> ```cs
> Button newButton = new Button();
> newButton.Size = new Size(128, 32);
> 
> Button newButton2 = new Button();
> newButton2.Size = new Size(128, 32);
> newButton2.Top = 36;
> 
> Button newButton3 = new Button();
> newButton3.Size = new Size(128, 32);
> newButton3.Top = 72;
> 
> this.Controls.Add(newButton);
> this.Controls.Add(newButton2);
> this.Controls.Add(newButton3);
> 
> theme_Definer1.ApplyTo(this); // apply to Parent, its children will update
> ```

> [!NOTE]
> Individual control name entries will have their Type properties, if any, applied first, and then their Name properties (also if any exist).
>
> (Basically, Name has higher priority than Type)

# 😼 Usage Example

**1.** Drag a `Theme Definer` from your toolbox onto your Form

<img width="429" height="60" alt="image" src="https://github.com/user-attachments/assets/440eb4a5-2b28-449b-821b-2c95291aeb46" />

---
**2.** To edit the theme, open the editor from Visual Studio's `Properties` panel. *(The "..." button placed next to the conveniently named "Click to Edit Theme" property)*

<img width="424" height="267" alt="image" src="https://github.com/user-attachments/assets/c89cfb12-11a3-49ca-bf25-7657c46aedef" />

---
**3.** This form appears. For beginners, you can press "Import Controls from Current Form", and not worry about the UI too much.

This button will process every control in your Form that's currently opened in the designer (if any) and get their names and types, which you can then select from a check list.

You also don't have to worry about the `Theme`'s name unless you want to use it in another Form later.

<img width="1378" height="879" alt="image" src="https://github.com/user-attachments/assets/a4c70764-9e32-411c-8019-763f3a6eb86e" />

---
**4.** Here, select which types (or individual controls) you want to theme. In my case, I want to theme every Chart control, so I check "cuiChartLine" in the list and press "OK".

(Notice that below the list, the "Import Types" option is selected. You can import individual controls by their names with the "Import Names" option.)

<img width="1374" height="938" alt="image" src="https://github.com/user-attachments/assets/ecac5bc0-892f-420d-8564-ba3e798e1426" />

---
**5.** The type's name (or the control's name) is in the list - Select it from the list to edit its "changing properties" *(properties which will change once you load this theme)*

<img width="773" height="703" alt="image" src="https://github.com/user-attachments/assets/023d3f6c-2a10-4ccf-9a76-732dec173d53" />

---
**6.** Currently, no properties are being changed. Press "Add New" in the bottom-right of the "Edit Properties" panel, and choose which properties you want to modify with your `Theme`

In this example, I only want to change the `UseBezier` property, so I select just that and press "OK":

<img width="1024" height="575" alt="image" src="https://github.com/user-attachments/assets/f99740de-85da-4822-8d44-25e3184d2ad3" />

---
**7.** When a property is selected from the list - An editor appears above.<br>
I want the `UseBezier` property to be set to `True` with my `Theme`, so I checked the "Property Value" checkbox:

<img width="773" height="700" alt="image" src="https://github.com/user-attachments/assets/443ff510-6a32-42f5-89ac-c17f9d41668c" />

---
**8.** Since this is just an example, I'll stop here. Press the "OK" button in the top-right to save your theme.

<img width="777" height="117" alt="image" src="https://github.com/user-attachments/assets/65c4ccce-eb09-495b-a303-8f290c73cc72" />

---
**10.** I want to apply the theme when a button in my example app is pressed.

This is actually simple, you call your theme definer's `.ApplyToForm(Form targetForm)` method:

```cs
     private void cuiButton1_Click(object sender, EventArgs e)
     {
         theme_Definer1.ApplyToForm(this);
     }
```
## The End Result

This is my app before clicking the button:
<img width="822" height="516" alt="image" src="https://github.com/user-attachments/assets/76193231-646b-47c2-b1dc-e50bc7987224" />

This is the same app after I clicked the button:
<img width="828" height="519" alt="image" src="https://github.com/user-attachments/assets/c1048594-9ba2-4212-a50d-9441c24877a3" />

**As visible in the photos, the chart control now draws bezier curves instead of straight lines, because its "UseBezier" property's value had been changed to `True`**
