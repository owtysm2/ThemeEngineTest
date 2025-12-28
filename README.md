> [!CAUTION]
> (in-dev and not recommended for prod use, at all)

**This is rather a proof-of-concept**, and this had most definitely been done before.<br>

---
# 📃 The Overview
This project aims to provide theming(*-ish?*) capabilities for WinForms.<br>
You can define themes with the `Theme Definer` component. Then, give the theme a name, mark which controls to affect, pick what properties to change and to what values.

## Quick Explanation
`"Themes"` can be shared across forms, as when your app starts, all themes report themselves to the `Internal Theme Manager` class.<br>
A `"Theme"` is an object created by the `Theme Definer`. It contains the theme's name, alongside the info on what controls and/or properties to change.

### In short
- Each theme is created with a `Theme Definer`
- Each theme gets assigned a name and a list of controls to affect
- Each control gets assigned a list of properties to change.

<img width="1609" height="932" alt="image" src="https://github.com/user-attachments/assets/6450a3d0-ed7f-42d0-9c9b-619ca1eccdc3" />

# 😼 Usage Example
(screenshots are currently outdated)

**1.** Drag a `Theme Definer` from your toolbox onto your Form

<img width="429" height="60" alt="image" src="https://github.com/user-attachments/assets/440eb4a5-2b28-449b-821b-2c95291aeb46" />

---
**2.** To edit the theme, open the editor from Visual Studio's `Properties` panel. *(The "..." button placed next to the conveniently named "Click to Edit Theme" property)*

<img width="421" height="82" alt="image" src="https://github.com/user-attachments/assets/fadff5b4-22ee-49af-ae32-01a08b0ed7c1" />

---
**3.** This form appears. For beginners, you can press "Import Controls from Current Form", and not worry about the UI too much.

You also don't have to worry about the `Theme`'s name unless you want to use it in another Form later.

<img width="767" height="696" alt="image" src="https://github.com/user-attachments/assets/8f737779-4444-4e0d-898b-8179d57d9414" />

---
**4.** Here, select which controls you want to theme. In my case, I want to theme the Chart control, so I select only "cuiChartLine1" and press "OK".

<img width="1603" height="930" alt="image" src="https://github.com/user-attachments/assets/7e603657-5005-4a02-be38-8635eca0d500" />

---
**5.** The control is in the list - Select it from the list to edit its "changing properties" *(properties which will change once you load this theme)*

<img width="763" height="601" alt="image" src="https://github.com/user-attachments/assets/c11ef471-6038-4c61-ab05-69a73d010ab4" />

---
**6.** Currently, no properties are being changed. Press "Add New" in the bottom-right of the "Edit Properties" panel, and a new "Property Creator" Form will appear.

<img width="331" height="246" alt="image" src="https://github.com/user-attachments/assets/c5126b4a-14f9-45c1-91f7-7b7257730317" />

---
**7.** The cuiChartLine has a boolean property called `UseBezier`.

<img width="210" height="95" alt="image" src="https://github.com/user-attachments/assets/29268cfc-6b5d-4c9a-b999-7c7edf05df25" />

Let's try to change it to true when this `Theme` is applied.<br>
**Here is how to set it up:** You type in the property's name, choose its type from the list, and set the target value you want your `Theme` to use for this property.

<img width="331" height="250" alt="image" src="https://github.com/user-attachments/assets/c8c5663a-1392-4fbb-ab85-eb1934001347" />

---
**8.** I pressed "OK", and the "changing property"'s name now appears in the "changing properties" list.<br>
When you select a "changing property" in the list, an editor appears above (the same as if you were to add a new "changing property").

This editor allows you to quickly change an already existing "changing property"'s value or type.

<img width="766" height="697" alt="image" src="https://github.com/user-attachments/assets/7e4891b9-f31e-4eab-b0aa-427c96529390" />

---
**9.** Since this is just an example, I'll stop here. Press the "OK" button in the top-right to save your theme.

<img width="777" height="117" alt="image" src="https://github.com/user-attachments/assets/65c4ccce-eb09-495b-a303-8f290c73cc72" />

---
**10.** I want to apply the theme when a button in my app is pressed.<br>
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
