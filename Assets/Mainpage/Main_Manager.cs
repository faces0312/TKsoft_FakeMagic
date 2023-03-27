using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Main_Manager : MonoBehaviour
{
    public TextMeshProUGUI money;
    public TextMeshProUGUI score;

    //업그레이드페이지 관련
    public GameObject upgrade_page;
    public GameObject upgrade_normal_page;
    public GameObject upgrade_fire_page;
    public GameObject upgrade_wood_page;
    public GameObject upgrade_mecha_page;
    public GameObject complete_normal_page;
    public GameObject complete_fire_page;
    public GameObject complete_wood_page;
    public GameObject complete_mecha_page;
    public GameObject complete_normal;
    public GameObject complete_fire;
    public GameObject complete_wood;
    public GameObject complete_mecha;
    public TextMeshProUGUI normal_change;
    public TextMeshProUGUI fire_change;
    public TextMeshProUGUI wood_change;
    public TextMeshProUGUI mecha_change;
    public TextMeshProUGUI normal_money;
    public TextMeshProUGUI fire_money;
    public TextMeshProUGUI wood_money;
    public TextMeshProUGUI mecha_money;
    public Button normal_upgrade;
    public Button fire_upgrade;
    public Button wood_upgrade;
    public Button mecha_upgrade;
    public TextMeshProUGUI normal_lv;
    public TextMeshProUGUI fire_lv;
    public TextMeshProUGUI wood_lv;
    public TextMeshProUGUI mecha_lv;
    public TextMeshProUGUI normal_atk;
    public TextMeshProUGUI fire_atk;
    public TextMeshProUGUI wood_atk;
    public TextMeshProUGUI mecha_atk;
    public GameObject is_not_enough_coin_normal;
    public GameObject is_not_enough_coin_fire;
    public GameObject is_not_enough_coin_wood;
    public GameObject is_not_enough_coin_mecha;


    private void Start()
    {
        Time.timeScale = 1;
        upgrade_page.gameObject.SetActive(false);
        upgrade_normal_page.gameObject.SetActive(false);
        upgrade_fire_page.gameObject.SetActive(false);
        upgrade_wood_page.gameObject.SetActive(false);
        upgrade_mecha_page.gameObject.SetActive(false);
        complete_normal_page.gameObject.SetActive(false);
        complete_fire_page.gameObject.SetActive(false);
        complete_wood_page.gameObject.SetActive(false);
        complete_mecha_page.gameObject.SetActive(false);

        is_not_enough_coin_normal.gameObject.SetActive(false);
        is_not_enough_coin_fire.gameObject.SetActive(false);
        is_not_enough_coin_wood.gameObject.SetActive(false);
        is_not_enough_coin_mecha.gameObject.SetActive(false);

        /*Data.Instance.gameData.player_normal_lv = 0;
        Data.Instance.gameData.player_fire_lv = 0;
        Data.Instance.gameData.player_wood_lv = 0;
        Data.Instance.gameData.player_mecha_lv = 0;

        Data.Instance.gameData.money = 3300;*/
    }
    public void Game_Start()
    {
        SceneManager.LoadScene("SampleScene");
    }
    //업그레이드 관련ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
    public void Upgrade_Page()
    {
        upgrade_page.gameObject.SetActive(true);
    }
    public void Normal_Upgrade_Page()
    {
        upgrade_normal_page.gameObject.SetActive(true);
    }
    public void Dis_Normal_Upgrade_Page()
    {
        is_not_enough_coin_normal.gameObject.SetActive(false);
        upgrade_normal_page.gameObject.SetActive(false);
    }
    public void Fire_Upgrade_Page()
    {
        upgrade_fire_page.gameObject.SetActive(true);
    }
    public void Dis_Fire_Upgrade_Page()
    {
        is_not_enough_coin_fire.gameObject.SetActive(false);
        upgrade_fire_page.gameObject.SetActive(false);
    }
    public void Wood_Upgrade_Page()
    {
        upgrade_wood_page.gameObject.SetActive(true);
    }
    public void Dis_Wood_Upgrade_Page()
    {
        is_not_enough_coin_wood.gameObject.SetActive(false);
        upgrade_wood_page.gameObject.SetActive(false);
    }
    public void Mecha_Upgrade_Page()
    {
        upgrade_mecha_page.gameObject.SetActive(true);
    }
    public void Dis_Mecha_Upgrade_Page()
    {
        is_not_enough_coin_mecha.gameObject.SetActive(false);
        upgrade_mecha_page.gameObject.SetActive(false);
    }
    public void Normal_Upgrade()
    {
        if (Data.Instance.gameData.money < (Data.Instance.gameData.player_normal_lv + 1) * 1000)
        {
            is_not_enough_coin_normal.gameObject.SetActive(true);
            StopCoroutine(nameof(Not_Enough_Normal));
            StartCoroutine(nameof(Not_Enough_Normal));
        }
        else
        {
            complete_normal_page.gameObject.SetActive(true);
            StartCoroutine(Complete_Normal());
            Data.Instance.gameData.player_normal_lv++;
            Data.Instance.gameData.player_normal++;
            Data.Instance.gameData.money -= (Data.Instance.gameData.player_normal_lv * 1000);
            Data.Instance.SaveGameData();
        }
    }
    public void Fire_Upgrade()
    {

        if (Data.Instance.gameData.money < (Data.Instance.gameData.player_fire_lv + 1) * 1000)
        {
            is_not_enough_coin_fire.gameObject.SetActive(true);
            StopCoroutine(nameof(Not_Enough_Fire));
            StartCoroutine(nameof(Not_Enough_Fire));
        }
        else
        {
            complete_fire_page.gameObject.SetActive(true);
            StartCoroutine(Complete_Fire());
            Data.Instance.gameData.player_fire_lv++;
            Data.Instance.gameData.player_fire++;
            Data.Instance.gameData.money -= (Data.Instance.gameData.player_fire_lv * 1000);
            Data.Instance.SaveGameData();
        }
    }
    public void Wood_Upgrade()
    {
        if (Data.Instance.gameData.money < (Data.Instance.gameData.player_wood_lv + 1) * 1000)
        {
            is_not_enough_coin_wood.gameObject.SetActive(true);
            StopCoroutine(nameof(Not_Enough_Wood));
            StartCoroutine(nameof(Not_Enough_Wood));
        }
        else
        {
            complete_wood_page.gameObject.SetActive(true);
            StartCoroutine(Complete_Wood());
            Data.Instance.gameData.player_wood_lv++;
            Data.Instance.gameData.player_wood++;
            Data.Instance.gameData.money -= (Data.Instance.gameData.player_wood_lv * 1000);
            Data.Instance.SaveGameData();
        }
    }
    public void Mecha_Upgrade()
    {
        if (Data.Instance.gameData.money < (Data.Instance.gameData.player_mecha_lv + 1) * 1000)
        {
            is_not_enough_coin_mecha.gameObject.SetActive(true);
            StopCoroutine(nameof(Not_Enough_Mecha));
            StartCoroutine(nameof(Not_Enough_Mecha));
        }
        else
        {
            complete_mecha_page.gameObject.SetActive(true);
            StartCoroutine(Complete_Mecha());
            Data.Instance.gameData.player_mecha_lv++;
            Data.Instance.gameData.player_mecha++;
            Data.Instance.gameData.money -= (Data.Instance.gameData.player_mecha_lv * 1000);
            Data.Instance.SaveGameData();
        }
    }
    public void Dis_Complete_Normal()
    {
        complete_normal_page.gameObject.SetActive(false);
    }
    public void Dis_Complete_Fire()
    {
        complete_fire_page.gameObject.SetActive(false);
    }
    public void Dis_Complete_Wood()
    {
        complete_wood_page.gameObject.SetActive(false);
    }
    public void Dis_Complete_Mecha()
    {
        complete_mecha_page.gameObject.SetActive(false);
    }
    public void Dis_Upgrade_Page()
    {
        upgrade_page.gameObject.SetActive(false);
    }
    //ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

    private void Update()
    {
        money.text = Data.Instance.gameData.money.ToString();
        score.text = Data.Instance.gameData.best_score.ToString();

        normal_lv.text = "Lv " + Data.Instance.gameData.player_normal_lv.ToString();
        fire_lv.text = "Lv " + Data.Instance.gameData.player_fire_lv.ToString();
        wood_lv.text = "Lv " + Data.Instance.gameData.player_wood_lv.ToString();
        mecha_lv.text = "Lv " + Data.Instance.gameData.player_mecha_lv.ToString();

        normal_atk.text = "데미지 +" + Data.Instance.gameData.player_normal_lv.ToString();
        fire_atk.text = "데미지 +" + Data.Instance.gameData.player_fire_lv.ToString();
        wood_atk.text = "데미지 +" + Data.Instance.gameData.player_wood_lv.ToString();
        mecha_atk.text = "데미지 +" + Data.Instance.gameData.player_mecha_lv.ToString();

        normal_change.text = "+" + Data.Instance.gameData.player_normal_lv.ToString() + " -> +" + (Data.Instance.gameData.player_normal_lv + 1).ToString();
        fire_change.text = "+" + Data.Instance.gameData.player_fire_lv.ToString() + " -> +" + (Data.Instance.gameData.player_fire_lv + 1).ToString();
        wood_change.text = "+" + Data.Instance.gameData.player_wood_lv.ToString() + " -> +" + (Data.Instance.gameData.player_wood_lv + 1).ToString();
        mecha_change.text = "+" + Data.Instance.gameData.player_mecha_lv.ToString() + " -> +" + (Data.Instance.gameData.player_mecha_lv + 1).ToString();

        normal_money.text = "비용 " + ((Data.Instance.gameData.player_normal_lv + 1) * 1000).ToString();
        fire_money.text = "비용 " + ((Data.Instance.gameData.player_fire_lv + 1) * 1000).ToString();
        wood_money.text = "비용 " + ((Data.Instance.gameData.player_wood_lv + 1) * 1000).ToString();
        mecha_money.text = "비용 " + ((Data.Instance.gameData.player_mecha_lv + 1) * 1000).ToString();

    }

    IEnumerator Complete_Normal()
    {
        float scale = 0.5f;
        for(int i=0; i<10; i++)
        {
            complete_normal.gameObject.transform.localScale = new Vector3(scale, scale);
            scale += 0.05f;
            yield return new WaitForSeconds(0.0001f);
        }
    }

    IEnumerator Complete_Fire()
    {
        float scale = 0.5f;
        for (int i = 0; i < 10; i++)
        {
            complete_fire.gameObject.transform.localScale = new Vector3(scale, scale);
            scale += 0.05f;
            yield return new WaitForSeconds(0.0001f);
        }
    }

    IEnumerator Complete_Wood()
    {
        float scale = 0.5f;
        for (int i = 0; i < 10; i++)
        {
            complete_wood.gameObject.transform.localScale = new Vector3(scale, scale);
            scale += 0.05f;
            yield return new WaitForSeconds(0.0001f);
        }
    }

    IEnumerator Complete_Mecha()
    {
        float scale = 0.5f;
        for (int i = 0; i < 10; i++)
        {
            complete_mecha.gameObject.transform.localScale = new Vector3(scale, scale);
            scale += 0.05f;
            yield return new WaitForSeconds(0.0001f);
        }
    }

    IEnumerator Not_Enough_Normal()
    {
        is_not_enough_coin_normal.transform.localPosition = new Vector3(0, -320);
        for(int i=0; i<36; i++)
        {
            is_not_enough_coin_normal.transform.localPosition = new Vector3(is_not_enough_coin_normal.transform.localPosition.x, is_not_enough_coin_normal.transform.localPosition.y + 5);
            yield return new WaitForSeconds(0.0001f);
        }
        yield return new WaitForSeconds(0.3f);
        is_not_enough_coin_normal.gameObject.SetActive(false);
    }

    IEnumerator Not_Enough_Fire()
    {
        is_not_enough_coin_fire.transform.localPosition = new Vector3(0, -320);
        for (int i = 0; i < 36; i++)
        {
            is_not_enough_coin_fire.transform.localPosition = new Vector3(is_not_enough_coin_fire.transform.localPosition.x, is_not_enough_coin_fire.transform.localPosition.y + 5);
            yield return new WaitForSeconds(0.0001f);
        }
        yield return new WaitForSeconds(0.3f);
        is_not_enough_coin_fire.gameObject.SetActive(false);
    }

    IEnumerator Not_Enough_Wood()
    {
        is_not_enough_coin_wood.transform.localPosition = new Vector3(0, -320);
        for (int i = 0; i < 36; i++)
        {
            is_not_enough_coin_wood.transform.localPosition = new Vector3(is_not_enough_coin_wood.transform.localPosition.x, is_not_enough_coin_wood.transform.localPosition.y + 5);
            yield return new WaitForSeconds(0.0001f);
        }
        yield return new WaitForSeconds(0.3f);
        is_not_enough_coin_wood.gameObject.SetActive(false);
    }

    IEnumerator Not_Enough_Mecha()
    {
        is_not_enough_coin_mecha.transform.localPosition = new Vector3(0, -320);
        for (int i = 0; i < 36; i++)
        {
            is_not_enough_coin_mecha.transform.localPosition = new Vector3(is_not_enough_coin_mecha.transform.localPosition.x, is_not_enough_coin_mecha.transform.localPosition.y + 5);
            yield return new WaitForSeconds(0.0001f);
        }
        yield return new WaitForSeconds(0.3f);
        is_not_enough_coin_mecha.gameObject.SetActive(false);
    }
}
