using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class raycastDetect : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    const string tripodName = "TripodStand", beaker1Name = "Beaker", boilingTubeName = "BoilingTube", thermometerName = "Thermometer", burnerName = "Bunsen Burner",crucibleName="Crucible",weightname= "Weighing scale", sodium="Sodium", lithium ="Lithium", potassium="Potassium", cesium="Cesium";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(this.gameObject.transform.position, transform.forward, out RaycastHit hit, 100))
        {
            // A hit was detected, do something with the hit information
            Debug.Log("Hit object: " + hit.transform.name);
            if(hit.collider.gameObject.CompareTag("EQUIPMENT"))
            {
                title.text = hit.collider.gameObject.name;
            }
            switch (hit.collider.gameObject.name)
            {
                case tripodName:
                    description.text =  "a piece of laboratory equipment that is used to hold a variety of items, including glassware, " +
                                        "hot plates, and other equipment, above a flame or heat source.Tripod stands are commonly used " +
                                        "in chemistry experiments that involve heating or boiling liquids or other substances, as they " +
                                        "provide a stable and adjustable platform for holding the glassware or equipment above a Bunsen" +
                                        "burner or other heat source.";
                    break;
                case beaker1Name:
                    description.text =  "a beaker is a cylindrical, glass or plastic container with a flat bottom and a lip or spout " +
                                        "for pouring. It is commonly used for holding, mixing, and heating liquids in laboratory settings."+
                                        "Beakers are often used in chemistry experiments to mix or dissolve substances, as their flat bottom " +
                                        "and wide mouth allow for easy stirring and pouring. They may also be used for measuring and dispensing " +
                                        "liquids, although they are not as precise as other types of measuring equipment such as burettes or pipettes.";
                    break;
                case boilingTubeName:
                    description.text =  "a boiling tube is a cylindrical, glass or plastic tube with a rounded bottom and an open top, " +
                                        "used for heating and boiling liquids in laboratory settings.Boiling tubes are similar in shape to test tubes, " +
                                        "but are larger and designed to withstand higher temperatures. They may also have a thicker wall or base to provide " +
                                        "greater resistance to thermal shock or breakage. They may have graduations or markings on the side to indicate the " +
                                        "volume of the liquid being held.";
                    break;
                case thermometerName:
                    description.text =  "a thermometer is a measuring device used to determine the temperature of a substance or environment. " +
                                        "It consists of a glass or plastic tube with a bulb at one end that is filled with a liquid, typically mercury" +
                                        " or alcohol, which expands and contracts as the temperature changes.The temperature scale used " +
                                        "in chemistry is typically the Celsius or Kelvin scale, although Fahrenheit may also be used in " +
                                        "some contexts. The thermometer is calibrated to accurately measure and display the temperature " +
                                        "on this scale, typically with graduations or markings on the side of the tube.";
                    break;
                case burnerName:
                    description.text =  "a Bunsen burner is a laboratory device used for heating, sterilization, and combustion. It consists of " +
                                        "a vertical metal tube with an adjustable air vent at the bottom, a gas inlet, and a burner tube that protrudes " +
                                        "horizontally from the side of the tube.Bunsen burners are commonly used in chemistry experiments to heat and " +
                                        "sterilize equipment, such as test tubes and flasks, and to perform combustion reactions. They may also be used" +
                                        " to generate heat for distillation, melting, or boiling of substances, and for flame tests to identify the presence " +
                                        "of certain elements in a sample.";
                    break;
                case crucibleName:
                    description.text = "a crucible is a small, cup-shaped container made of ceramic, metal, or glass that is used for heating, melting, and " +
                                        "analyzing materials. Crucibles are designed to withstand high temperatures and to resist chemical attack from the " +
                                        "substances being heated or melted.";
                    break;
                case weightname:
                    description.text =  "a weighing scale is an instrument used to measure the mass or weight of a substance or object. Weighing scales are " +
                                        "important tools in many laboratory applications, as accurate measurement of mass is often critical to the success of an experiment.";
                    

                    break;
                case sodium:
                    description.text = "Sodium is a chemical element with the symbol Na (from Latin natrium) and atomic number 11. It is a soft, " +
                                       "silvery-white, highly reactive metal. Sodium is an alkali metal, being in group 1 of the periodic table. ";

                    break;
                case lithium:
                    description.text = "Lithium (from Ancient Greek ????? (líthos) 'stone') is a chemical element with the symbol Li and atomic number 3. It is a soft, silvery-white alkali metal. " +
                                       "Under standard conditions, it is the least dense metal and the least dense solid element. ";

                    break;
                case potassium:
                    description.text = "Potassium is the chemical element with the symbol K (from Neo-Latin kalium) and atomic number 19. It is a silvery white metal that is soft enough to easily cut with a knife." +
                                       "Potassium metal reacts rapidly with atmospheric oxygen to form flaky white potassium peroxide in only seconds of exposure. ";

                    break;
                case cesium:
                    description.text = "cesium (Cs), also spelled caesium, chemical element of Group 1 (also called Group Ia) of the periodic table, the alkali metal group, and the first element to be discovered spectroscopically (1860), " +
                                       "by German scientists Robert Bunsen and Gustav Kirchhoff, who named it for the unique blue lines of its spectrum (Latin caesius, “sky-blue”).";


                    break;


                default:
                    break;





            }


        }
    }
}
