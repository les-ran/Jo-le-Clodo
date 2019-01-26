using UnityEngine;
using System.Collections;

public class MoveJo : MonoBehaviour
{

    public float speed;             // variable pour stocker la vitesse de mouvement du joueur.

    private Rigidbody2D rb2d;       // stocke une référence vers le composant Rigidbody2D nécessaire pour utiliser la physique 2D.

    // Initialisation
    void Start()
    {
        // Récupère et conserve la référence vers le composant Rigidbody2D afin de pouvoir y accéder plus tard.
        rb2d = GetComponent<Rigidbody2D>();
    }

    // La fonction FixedUpdate() est appelée à intervalle régulier et est indépendante du nombre d'images par seconde. Placez votre code physique ici.
    void FixedUpdate()
    {
        // Stocke l'entrée horizontale dans la variable moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Stocke l'entrée verticale dans la variable moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        // Utilise les deux nombres pour créer un Vector2.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Appelle la fonction AddForce() du Rigidbody2D rb2d avec le mouvement multiplié par la vitesse.
        rb2d.AddForce(movement * speed);
    }
}