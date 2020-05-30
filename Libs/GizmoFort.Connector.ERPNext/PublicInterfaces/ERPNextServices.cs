using GizmoFort.Connector.ERPNext.ERPTypes.Address;
//Add As using imports  5/27/2020 8:46:13 AM
using GizmoFort.Connector.ERPNext.ERPTypes.Account;
using GizmoFort.Connector.ERPNext.ERPTypes.At_austria_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Be_l10nbe_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Ch_l10nch_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Cl_cl_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Cn_l10n_chart_china;
using GizmoFort.Connector.ERPNext.ERPTypes.Co_vauxoo_mx_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Cr_account_chart_template_0;
using GizmoFort.Connector.ERPNext.ERPTypes.Cr_account_chart_template_x;
using GizmoFort.Connector.ERPNext.ERPTypes.De_l10n_de_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Ec_ec_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Es_account_chart_template_common;
using GizmoFort.Connector.ERPNext.ERPTypes.Et_l10n_et;
using GizmoFort.Connector.ERPNext.ERPTypes.Gr_l10n_gr_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Hn_cuentas_plantilla;
using GizmoFort.Connector.ERPNext.ERPTypes.Hr_l10n_hr_chart_template_rrif;
using GizmoFort.Connector.ERPNext.ERPTypes.It_l10n_it_chart_template_generic;
using GizmoFort.Connector.ERPNext.ERPTypes.Ma_l10n_kzc_temp_chart;
using GizmoFort.Connector.ERPNext.ERPTypes.Pa_l10npa_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Pe_pe_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Pl_pl_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Pt_pt_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Ro_ro_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Syscohada_syscohada_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Th_chart;
using GizmoFort.Connector.ERPNext.ERPTypes.Tr_l10ntr_tek_duzen_hesap;
using GizmoFort.Connector.ERPNext.ERPTypes.Uy_uy_chart_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Ve_ve_chart_template_amd;
using GizmoFort.Connector.ERPNext.ERPTypes.Ae_uae_chart_template_standard;
using GizmoFort.Connector.ERPNext.ERPTypes.Ar_chart_of_accounts;
using GizmoFort.Connector.ERPNext.ERPTypes.Br_planilha_de_contas;
using GizmoFort.Connector.ERPNext.ERPTypes.Ca_plan_comptable_pour_les_provinces_francophones;
using GizmoFort.Connector.ERPNext.ERPTypes.De_kontenplan_SKR03_gnucash;
using GizmoFort.Connector.ERPNext.ERPTypes.De_kontenplan_SKR04;
using GizmoFort.Connector.ERPNext.ERPTypes.De_kontenplan_SKR04_with_account_number;
using GizmoFort.Connector.ERPNext.ERPTypes.El_salvador_standard;
using GizmoFort.Connector.ERPNext.ERPTypes.Fr_plan_comptable_general;
using GizmoFort.Connector.ERPNext.ERPTypes.Gt_cuentas_plantilla;
using GizmoFort.Connector.ERPNext.ERPTypes.Hu_chart_of_accounts;
using GizmoFort.Connector.ERPNext.ERPTypes.Id_chart_of_accounts;
using GizmoFort.Connector.ERPNext.ERPTypes.In_standard_chart_of_accounts;
using GizmoFort.Connector.ERPNext.ERPTypes.Mx_plan_de_cuentas;
using GizmoFort.Connector.ERPNext.ERPTypes.Ni_catalogo_de_cuentas;
using GizmoFort.Connector.ERPNext.ERPTypes.Nl_grootboekschema;
using GizmoFort.Connector.ERPNext.ERPTypes.Sg_default_coa;
using GizmoFort.Connector.ERPNext.ERPTypes.Sg_fnb_coa;
using GizmoFort.Connector.ERPNext.ERPTypes.Tw_chart_of_accounts;
using GizmoFort.Connector.ERPNext.ERPTypes.Accounting_dimension;
using GizmoFort.Connector.ERPNext.ERPTypes.Accounting_dimension_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Accounting_period;
using GizmoFort.Connector.ERPNext.ERPTypes.Accounts_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Allowed_to_transact_with;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_account_subtype;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_account_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_clearance;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_clearance_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_guarantee;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_settings_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_invoice_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_payment_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_statement_transaction_settings_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction_mapping;
using GizmoFort.Connector.ERPNext.ERPTypes.Bank_transaction_payments;
using GizmoFort.Connector.ERPNext.ERPTypes.Budget;
using GizmoFort.Connector.ERPNext.ERPTypes.Budget_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Cashier_closing;
using GizmoFort.Connector.ERPNext.ERPTypes.Cashier_closing_payments;
using GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapper;
using GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping;
using GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_accounts;
using GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Cash_flow_mapping_template_details;
using GizmoFort.Connector.ERPNext.ERPTypes.Chart_of_accounts_importer;
using GizmoFort.Connector.ERPNext.ERPTypes.Cheque_print_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Closed_document;
using GizmoFort.Connector.ERPNext.ERPTypes.Cost_center;
using GizmoFort.Connector.ERPNext.ERPTypes.Coupon_code;
using GizmoFort.Connector.ERPNext.ERPTypes.C_form;
using GizmoFort.Connector.ERPNext.ERPTypes.C_form_invoice_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Discounted_invoice;
using GizmoFort.Connector.ERPNext.ERPTypes.Exchange_rate_revaluation;
using GizmoFort.Connector.ERPNext.ERPTypes.Exchange_rate_revaluation_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Finance_book;
using GizmoFort.Connector.ERPNext.ERPTypes.Fiscal_year;
using GizmoFort.Connector.ERPNext.ERPTypes.Fiscal_year_company;
using GizmoFort.Connector.ERPNext.ERPTypes.Gl_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Gst_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Invoice_discounting;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_tax_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_tax_template_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Journal_entry_template_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_point_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_point_entry_redemption;
using GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_program;
using GizmoFort.Connector.ERPNext.ERPTypes.Loyalty_program_collection;
using GizmoFort.Connector.ERPNext.ERPTypes.Mode_of_payment;
using GizmoFort.Connector.ERPNext.ERPTypes.Mode_of_payment_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Monthly_distribution;
using GizmoFort.Connector.ERPNext.ERPTypes.Monthly_distribution_percentage;
using GizmoFort.Connector.ERPNext.ERPTypes.Opening_invoice_creation_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Opening_invoice_creation_tool_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Party_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry_deduction;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_entry_reference;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_gateway_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_order;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_order_reference;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation_invoice;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_reconciliation_payment;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_request;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_term;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_terms_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Payment_terms_template_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Period_closing_voucher;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_customer_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_field;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_item_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_profile;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_profile_user;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule;
using GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_brand;
using GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_item_code;
using GizmoFort.Connector.ERPNext.ERPTypes.Pricing_rule_item_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Process_deferred_accounting;
using GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme;
using GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme_price_discount;
using GizmoFort.Connector.ERPNext.ERPTypes.Promotional_scheme_product_discount;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_invoice;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_invoice_advance;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_invoice_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_taxes_and_charges;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_taxes_and_charges_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Salary_component_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_advance;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_payment;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_invoice_timesheet;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_taxes_and_charges;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_taxes_and_charges_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Shareholder;
using GizmoFort.Connector.ERPNext.ERPTypes.Share_balance;
using GizmoFort.Connector.ERPNext.ERPTypes.Share_transfer;
using GizmoFort.Connector.ERPNext.ERPTypes.Share_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule;
using GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule_condition;
using GizmoFort.Connector.ERPNext.ERPTypes.Shipping_rule_country;
using GizmoFort.Connector.ERPNext.ERPTypes.Subscription;
using GizmoFort.Connector.ERPNext.ERPTypes.Subscription_invoice;
using GizmoFort.Connector.ERPNext.ERPTypes.Subscription_plan;
using GizmoFort.Connector.ERPNext.ERPTypes.Subscription_plan_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Subscription_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Tax_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Tax_rule;
using GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Tax_withholding_rate;
using GizmoFort.Connector.ERPNext.ERPTypes.Agriculture_analysis_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Agriculture_task;
using GizmoFort.Connector.ERPNext.ERPTypes.Crop;
using GizmoFort.Connector.ERPNext.ERPTypes.Crop_cycle;
using GizmoFort.Connector.ERPNext.ERPTypes.Detected_disease;
using GizmoFort.Connector.ERPNext.ERPTypes.Disease;
using GizmoFort.Connector.ERPNext.ERPTypes.Fertilizer;
using GizmoFort.Connector.ERPNext.ERPTypes.Fertilizer_content;
using GizmoFort.Connector.ERPNext.ERPTypes.Linked_location;
using GizmoFort.Connector.ERPNext.ERPTypes.Linked_plant_analysis;
using GizmoFort.Connector.ERPNext.ERPTypes.Linked_soil_analysis;
using GizmoFort.Connector.ERPNext.ERPTypes.Linked_soil_texture;
using GizmoFort.Connector.ERPNext.ERPTypes.Plant_analysis;
using GizmoFort.Connector.ERPNext.ERPTypes.Plant_analysis_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Soil_analysis;
using GizmoFort.Connector.ERPNext.ERPTypes.Soil_analysis_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Soil_texture;
using GizmoFort.Connector.ERPNext.ERPTypes.Soil_texture_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Water_analysis;
using GizmoFort.Connector.ERPNext.ERPTypes.Water_analysis_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Weather;
using GizmoFort.Connector.ERPNext.ERPTypes.Weather_parameter;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_category_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_finance_book;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_log;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_task;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_maintenance_team;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_movement;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_movement_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_repair;
using GizmoFort.Connector.ERPNext.ERPTypes.Asset_value_adjustment;
using GizmoFort.Connector.ERPNext.ERPTypes.Depreciation_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Linked_location;
using GizmoFort.Connector.ERPNext.ERPTypes.Location;
using GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_team_member;
using GizmoFort.Connector.ERPNext.ERPTypes.Buying_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_order;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_order_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_order_item_supplied;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt_item_supplied;
using GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation;
using GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Request_for_quotation_supplier;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_quotation;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_quotation_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_period;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_scoring_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_scoring_standing;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_scoring_variable;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_standing;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_scorecard_variable;
using GizmoFort.Connector.ERPNext.ERPTypes.Call_log;
using GizmoFort.Connector.ERPNext.ERPTypes.Communication_medium;
using GizmoFort.Connector.ERPNext.ERPTypes.Communication_medium_timeslot;
using GizmoFort.Connector.ERPNext.ERPTypes.Appointment;
using GizmoFort.Connector.ERPNext.ERPTypes.Appointment_booking_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Appointment_booking_slots;
using GizmoFort.Connector.ERPNext.ERPTypes.Availability_of_slots;
using GizmoFort.Connector.ERPNext.ERPTypes.Campaign_email_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Contract;
using GizmoFort.Connector.ERPNext.ERPTypes.Contract_fulfilment_checklist;
using GizmoFort.Connector.ERPNext.ERPTypes.Contract_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Contract_template_fulfilment_terms;
using GizmoFort.Connector.ERPNext.ERPTypes.Email_campaign;
using GizmoFort.Connector.ERPNext.ERPTypes.Lead;
using GizmoFort.Connector.ERPNext.ERPTypes.Linkedin_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Lost_reason_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Market_segment;
using GizmoFort.Connector.ERPNext.ERPTypes.Opportunity;
using GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_lost_reason;
using GizmoFort.Connector.ERPNext.ERPTypes.Opportunity_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_stage;
using GizmoFort.Connector.ERPNext.ERPTypes.Social_media_post;
using GizmoFort.Connector.ERPNext.ERPTypes.Twitter_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Academic_term;
using GizmoFort.Connector.ERPNext.ERPTypes.Academic_year;
using GizmoFort.Connector.ERPNext.ERPTypes.Article;
using GizmoFort.Connector.ERPNext.ERPTypes.Assessment_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Assessment_criteria_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Assessment_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Assessment_plan;
using GizmoFort.Connector.ERPNext.ERPTypes.Assessment_plan_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result;
using GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Assessment_result_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Content_activity;
using GizmoFort.Connector.ERPNext.ERPTypes.Content_question;
using GizmoFort.Connector.ERPNext.ERPTypes.Course;
using GizmoFort.Connector.ERPNext.ERPTypes.Course_activity;
using GizmoFort.Connector.ERPNext.ERPTypes.Course_assessment_criteria;
using GizmoFort.Connector.ERPNext.ERPTypes.Course_content;
using GizmoFort.Connector.ERPNext.ERPTypes.Course_enrollment;
using GizmoFort.Connector.ERPNext.ERPTypes.Course_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Course_scheduling_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Course_topic;
using GizmoFort.Connector.ERPNext.ERPTypes.Education_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Fees;
using GizmoFort.Connector.ERPNext.ERPTypes.Fee_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Fee_component;
using GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule_program;
using GizmoFort.Connector.ERPNext.ERPTypes.Fee_schedule_student_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Fee_structure;
using GizmoFort.Connector.ERPNext.ERPTypes.Grading_scale;
using GizmoFort.Connector.ERPNext.ERPTypes.Grading_scale_interval;
using GizmoFort.Connector.ERPNext.ERPTypes.Guardian;
using GizmoFort.Connector.ERPNext.ERPTypes.Guardian_interest;
using GizmoFort.Connector.ERPNext.ERPTypes.Guardian_student;
using GizmoFort.Connector.ERPNext.ERPTypes.Instructor;
using GizmoFort.Connector.ERPNext.ERPTypes.Instructor_log;
using GizmoFort.Connector.ERPNext.ERPTypes.Options;
using GizmoFort.Connector.ERPNext.ERPTypes.Program;
using GizmoFort.Connector.ERPNext.ERPTypes.Program_course;
using GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment;
using GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_course;
using GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_fee;
using GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Program_enrollment_tool_student;
using GizmoFort.Connector.ERPNext.ERPTypes.Program_fee;
using GizmoFort.Connector.ERPNext.ERPTypes.Question;
using GizmoFort.Connector.ERPNext.ERPTypes.Quiz;
using GizmoFort.Connector.ERPNext.ERPTypes.Quiz_activity;
using GizmoFort.Connector.ERPNext.ERPTypes.Quiz_question;
using GizmoFort.Connector.ERPNext.ERPTypes.Quiz_result;
using GizmoFort.Connector.ERPNext.ERPTypes.Room;
using GizmoFort.Connector.ERPNext.ERPTypes.School_house;
using GizmoFort.Connector.ERPNext.ERPTypes.Student;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_admission;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_admission_program;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_applicant;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_attendance;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_attendance_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_batch_name;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_group_creation_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_group_creation_tool_course;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_group_instructor;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_group_student;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_guardian;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_language;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_leave_application;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_log;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_report_generation_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_sibling;
using GizmoFort.Connector.ERPNext.ERPTypes.Student_siblings;
using GizmoFort.Connector.ERPNext.ERPTypes.Topic;
using GizmoFort.Connector.ERPNext.ERPTypes.Topic_content;
using GizmoFort.Connector.ERPNext.ERPTypes.Amazon_mws_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Exotel_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Gocardless_mandate;
using GizmoFort.Connector.ERPNext.ERPTypes.Gocardless_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Plaid_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Quickbooks_migrator;
using GizmoFort.Connector.ERPNext.ERPTypes.Shopify_log;
using GizmoFort.Connector.ERPNext.ERPTypes.Shopify_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Shopify_customer;
using GizmoFort.Connector.ERPNext.ERPTypes.Shopify_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Shopify_order;
using GizmoFort.Connector.ERPNext.ERPTypes.Shopify_tax_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Shopify_webhook_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Tally_migration;
using GizmoFort.Connector.ERPNext.ERPTypes.Woocommerce_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Antibiotic;
using GizmoFort.Connector.ERPNext.ERPTypes.Appointment_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Body_part;
using GizmoFort.Connector.ERPNext.ERPTypes.Body_part_link;
using GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure;
using GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Clinical_procedure_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Codification_table;
using GizmoFort.Connector.ERPNext.ERPTypes.Complaint;
using GizmoFort.Connector.ERPNext.ERPTypes.Diagnosis;
using GizmoFort.Connector.ERPNext.ERPTypes.Dosage_form;
using GizmoFort.Connector.ERPNext.ERPTypes.Dosage_strength;
using GizmoFort.Connector.ERPNext.ERPTypes.Drug_prescription;
using GizmoFort.Connector.ERPNext.ERPTypes.Exercise;
using GizmoFort.Connector.ERPNext.ERPTypes.Exercise_difficulty_level;
using GizmoFort.Connector.ERPNext.ERPTypes.Exercise_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Exercise_type_step;
using GizmoFort.Connector.ERPNext.ERPTypes.Fee_validity;
using GizmoFort.Connector.ERPNext.ERPTypes.Fee_validity_reference;
using GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_practitioner;
using GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_schedule_time_slot;
using GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_service_unit;
using GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_service_unit_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Healthcare_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Inpatient_occupancy;
using GizmoFort.Connector.ERPNext.ERPTypes.Inpatient_record;
using GizmoFort.Connector.ERPNext.ERPTypes.Lab_prescription;
using GizmoFort.Connector.ERPNext.ERPTypes.Lab_test;
using GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_groups;
using GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_sample;
using GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Lab_test_uom;
using GizmoFort.Connector.ERPNext.ERPTypes.Medical_code;
using GizmoFort.Connector.ERPNext.ERPTypes.Medical_code_standard;
using GizmoFort.Connector.ERPNext.ERPTypes.Medical_department;
using GizmoFort.Connector.ERPNext.ERPTypes.Normal_test_items;
using GizmoFort.Connector.ERPNext.ERPTypes.Normal_test_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_appointment;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_parameter;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_sheet;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_assessment_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter_diagnosis;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_encounter_symptom;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_medical_record;
using GizmoFort.Connector.ERPNext.ERPTypes.Patient_relation;
using GizmoFort.Connector.ERPNext.ERPTypes.Practitioner_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Practitioner_service_unit_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Prescription_dosage;
using GizmoFort.Connector.ERPNext.ERPTypes.Prescription_duration;
using GizmoFort.Connector.ERPNext.ERPTypes.Procedure_prescription;
using GizmoFort.Connector.ERPNext.ERPTypes.Sample_collection;
using GizmoFort.Connector.ERPNext.ERPTypes.Sensitivity;
using GizmoFort.Connector.ERPNext.ERPTypes.Sensitivity_test_items;
using GizmoFort.Connector.ERPNext.ERPTypes.Special_test_items;
using GizmoFort.Connector.ERPNext.ERPTypes.Special_test_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Therapy_plan;
using GizmoFort.Connector.ERPNext.ERPTypes.Therapy_plan_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Therapy_session;
using GizmoFort.Connector.ERPNext.ERPTypes.Therapy_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Vital_signs;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_amenity;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_package;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_pricing;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_pricing_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_pricing_package;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_reservation;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_reservation_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_room_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Hotel_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Additional_salary;
using GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter;
using GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter_content;
using GizmoFort.Connector.ERPNext.ERPTypes.Appointment_letter_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Appraisal;
using GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_goal;
using GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Appraisal_template_goal;
using GizmoFort.Connector.ERPNext.ERPTypes.Attendance;
using GizmoFort.Connector.ERPNext.ERPTypes.Attendance_request;
using GizmoFort.Connector.ERPNext.ERPTypes.Branch;
using GizmoFort.Connector.ERPNext.ERPTypes.Compensatory_leave_request;
using GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary;
using GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Daily_work_summary_group_user;
using GizmoFort.Connector.ERPNext.ERPTypes.Department;
using GizmoFort.Connector.ERPNext.ERPTypes.Department_approver;
using GizmoFort.Connector.ERPNext.ERPTypes.Designation;
using GizmoFort.Connector.ERPNext.ERPTypes.Designation_skill;
using GizmoFort.Connector.ERPNext.ERPTypes.Driver;
using GizmoFort.Connector.ERPNext.ERPTypes.Driving_license_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_advance;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_attendance_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_application;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_application_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_benefit_claim;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_boarding_activity;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_checkin;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_education;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_external_work_history;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_grade;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_group_table;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_health_insurance;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_incentive;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_internal_work_history;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding_activity;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_onboarding_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_other_income;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_promotion;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_property_history;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_separation;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_separation_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_skill;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_skill_map;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_declaration;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_declaration_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_proof_submission;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_proof_submission_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_tax_exemption_sub_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_training;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_transfer;
using GizmoFort.Connector.ERPNext.ERPTypes.Employee_transfer_property;
using GizmoFort.Connector.ERPNext.ERPTypes.Employment_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim;
using GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_account;
using GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_advance;
using GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Expense_claim_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Expense_taxes_and_charges;
using GizmoFort.Connector.ERPNext.ERPTypes.Holiday;
using GizmoFort.Connector.ERPNext.ERPTypes.Holiday_list;
using GizmoFort.Connector.ERPNext.ERPTypes.Hr_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Identification_document_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Income_tax_slab;
using GizmoFort.Connector.ERPNext.ERPTypes.Income_tax_slab_other_charges;
using GizmoFort.Connector.ERPNext.ERPTypes.Interest;
using GizmoFort.Connector.ERPNext.ERPTypes.Job_applicant;
using GizmoFort.Connector.ERPNext.ERPTypes.Job_applicant_source;
using GizmoFort.Connector.ERPNext.ERPTypes.Job_offer;
using GizmoFort.Connector.ERPNext.ERPTypes.Job_offer_term;
using GizmoFort.Connector.ERPNext.ERPTypes.Job_opening;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_allocation;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_application;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list_allow;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_block_list_date;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_control_panel;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_encashment;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_ledger_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_period;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_policy;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_policy_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Leave_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Offer_term;
using GizmoFort.Connector.ERPNext.ERPTypes.Payroll_employee_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Payroll_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Payroll_period;
using GizmoFort.Connector.ERPNext.ERPTypes.Payroll_period_date;
using GizmoFort.Connector.ERPNext.ERPTypes.Purpose_of_travel;
using GizmoFort.Connector.ERPNext.ERPTypes.Retention_bonus;
using GizmoFort.Connector.ERPNext.ERPTypes.Salary_component;
using GizmoFort.Connector.ERPNext.ERPTypes.Salary_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip;
using GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip_timesheet;
using GizmoFort.Connector.ERPNext.ERPTypes.Salary_structure;
using GizmoFort.Connector.ERPNext.ERPTypes.Salary_structure_assignment;
using GizmoFort.Connector.ERPNext.ERPTypes.Shift_assignment;
using GizmoFort.Connector.ERPNext.ERPTypes.Shift_request;
using GizmoFort.Connector.ERPNext.ERPTypes.Shift_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Skill;
using GizmoFort.Connector.ERPNext.ERPTypes.Staffing_plan;
using GizmoFort.Connector.ERPNext.ERPTypes.Staffing_plan_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Taxable_salary_slab;
using GizmoFort.Connector.ERPNext.ERPTypes.Training_event;
using GizmoFort.Connector.ERPNext.ERPTypes.Training_event_employee;
using GizmoFort.Connector.ERPNext.ERPTypes.Training_feedback;
using GizmoFort.Connector.ERPNext.ERPTypes.Training_program;
using GizmoFort.Connector.ERPNext.ERPTypes.Training_result;
using GizmoFort.Connector.ERPNext.ERPTypes.Training_result_employee;
using GizmoFort.Connector.ERPNext.ERPTypes.Travel_itinerary;
using GizmoFort.Connector.ERPNext.ERPTypes.Travel_request;
using GizmoFort.Connector.ERPNext.ERPTypes.Travel_request_costing;
using GizmoFort.Connector.ERPNext.ERPTypes.Upload_attendance;
using GizmoFort.Connector.ERPNext.ERPTypes.Vehicle;
using GizmoFort.Connector.ERPNext.ERPTypes.Vehicle_log;
using GizmoFort.Connector.ERPNext.ERPTypes.Vehicle_service;
using GizmoFort.Connector.ERPNext.ERPTypes.Hub_tracked_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Hub_user;
using GizmoFort.Connector.ERPNext.ERPTypes.Hub_users;
using GizmoFort.Connector.ERPNext.ERPTypes.Marketplace_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_application;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_disbursement;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_interest_accrual;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_repayment;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_repayment_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_security;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_pledge;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_price;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_shortfall;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_security_unpledge;
using GizmoFort.Connector.ERPNext.ERPTypes.Loan_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Pledge;
using GizmoFort.Connector.ERPNext.ERPTypes.Process_loan_interest_accrual;
using GizmoFort.Connector.ERPNext.ERPTypes.Process_loan_security_shortfall;
using GizmoFort.Connector.ERPNext.ERPTypes.Proposed_pledge;
using GizmoFort.Connector.ERPNext.ERPTypes.Repayment_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Salary_slip_loan;
using GizmoFort.Connector.ERPNext.ERPTypes.Sanctioned_loan_amount;
using GizmoFort.Connector.ERPNext.ERPTypes.Unpledge;
using GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule;
using GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_schedule_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_visit;
using GizmoFort.Connector.ERPNext.ERPTypes.Maintenance_visit_purpose;
using GizmoFort.Connector.ERPNext.ERPTypes.Blanket_order;
using GizmoFort.Connector.ERPNext.ERPTypes.Blanket_order_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bom;
using GizmoFort.Connector.ERPNext.ERPTypes.Bom_explosion_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bom_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bom_operation;
using GizmoFort.Connector.ERPNext.ERPTypes.Bom_scrap_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bom_update_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Bom_website_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Bom_website_operation;
using GizmoFort.Connector.ERPNext.ERPTypes.Downtime_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Job_card;
using GizmoFort.Connector.ERPNext.ERPTypes.Job_card_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Job_card_time_log;
using GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Material_request_plan_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Operation;
using GizmoFort.Connector.ERPNext.ERPTypes.Production_plan;
using GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_material_request;
using GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_material_request_warehouse;
using GizmoFort.Connector.ERPNext.ERPTypes.Production_plan_sales_order;
using GizmoFort.Connector.ERPNext.ERPTypes.Routing;
using GizmoFort.Connector.ERPNext.ERPTypes.Workstation;
using GizmoFort.Connector.ERPNext.ERPTypes.Workstation_working_hour;
using GizmoFort.Connector.ERPNext.ERPTypes.Work_order;
using GizmoFort.Connector.ERPNext.ERPTypes.Work_order_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Work_order_operation;
using GizmoFort.Connector.ERPNext.ERPTypes.Certification_application;
using GizmoFort.Connector.ERPNext.ERPTypes.Certified_consultant;
using GizmoFort.Connector.ERPNext.ERPTypes.Chapter;
using GizmoFort.Connector.ERPNext.ERPTypes.Chapter_member;
using GizmoFort.Connector.ERPNext.ERPTypes.Donor;
using GizmoFort.Connector.ERPNext.ERPTypes.Donor_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Grant_application;
using GizmoFort.Connector.ERPNext.ERPTypes.Member;
using GizmoFort.Connector.ERPNext.ERPTypes.Membership;
using GizmoFort.Connector.ERPNext.ERPTypes.Membership_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Membership_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Volunteer;
using GizmoFort.Connector.ERPNext.ERPTypes.Volunteer_skill;
using GizmoFort.Connector.ERPNext.ERPTypes.Volunteer_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Homepage;
using GizmoFort.Connector.ERPNext.ERPTypes.Homepage_featured_product;
using GizmoFort.Connector.ERPNext.ERPTypes.Homepage_section;
using GizmoFort.Connector.ERPNext.ERPTypes.Homepage_section_card;
using GizmoFort.Connector.ERPNext.ERPTypes.Products_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Website_attribute;
using GizmoFort.Connector.ERPNext.ERPTypes.Website_filter_field;
using GizmoFort.Connector.ERPNext.ERPTypes.Activity_cost;
using GizmoFort.Connector.ERPNext.ERPTypes.Activity_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Dependent_task;
using GizmoFort.Connector.ERPNext.ERPTypes.Project;
using GizmoFort.Connector.ERPNext.ERPTypes.Projects_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Project_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Project_template_task;
using GizmoFort.Connector.ERPNext.ERPTypes.Project_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Project_update;
using GizmoFort.Connector.ERPNext.ERPTypes.Project_user;
using GizmoFort.Connector.ERPNext.ERPTypes.Task;
using GizmoFort.Connector.ERPNext.ERPTypes.Task_depends_on;
using GizmoFort.Connector.ERPNext.ERPTypes.Task_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Timesheet;
using GizmoFort.Connector.ERPNext.ERPTypes.Timesheet_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_action;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_action_resolution;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_parameter;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_feedback_template_parameter;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_goal;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_goal_objective;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting_agenda;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_meeting_minutes;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_procedure;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_procedure_process;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_review;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_review_objective;
using GizmoFort.Connector.ERPNext.ERPTypes.Datev_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Gstr_3b_report;
using GizmoFort.Connector.ERPNext.ERPTypes.Gst_hsn_code;
using GizmoFort.Connector.ERPNext.ERPTypes.Gst_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Import_supplier_invoice;
using GizmoFort.Connector.ERPNext.ERPTypes.Lower_deduction_certificate;
using GizmoFort.Connector.ERPNext.ERPTypes.Restaurant;
using GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_menu;
using GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_menu_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_order_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_order_entry_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_reservation;
using GizmoFort.Connector.ERPNext.ERPTypes.Restaurant_table;
using GizmoFort.Connector.ERPNext.ERPTypes.Campaign;
using GizmoFort.Connector.ERPNext.ERPTypes.Customer;
using GizmoFort.Connector.ERPNext.ERPTypes.Customer_credit_limit;
using GizmoFort.Connector.ERPNext.ERPTypes.Industry_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Installation_note;
using GizmoFort.Connector.ERPNext.ERPTypes.Installation_note_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Lead_source;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_details;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_invoices;
using GizmoFort.Connector.ERPNext.ERPTypes.Pos_closing_voucher_taxes;
using GizmoFort.Connector.ERPNext.ERPTypes.Product_bundle;
using GizmoFort.Connector.ERPNext.ERPTypes.Product_bundle_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Quotation;
using GizmoFort.Connector.ERPNext.ERPTypes.Quotation_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_order;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_order_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_partner_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_team;
using GizmoFort.Connector.ERPNext.ERPTypes.Selling_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Sms_center;
using GizmoFort.Connector.ERPNext.ERPTypes.Authorization_control;
using GizmoFort.Connector.ERPNext.ERPTypes.Authorization_rule;
using GizmoFort.Connector.ERPNext.ERPTypes.Brand;
using GizmoFort.Connector.ERPNext.ERPTypes.Company;
using GizmoFort.Connector.ERPNext.ERPTypes.Currency_exchange;
using GizmoFort.Connector.ERPNext.ERPTypes.Customer_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Email_digest;
using GizmoFort.Connector.ERPNext.ERPTypes.Global_defaults;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Naming_series;
using GizmoFort.Connector.ERPNext.ERPTypes.Party_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Print_heading;
using GizmoFort.Connector.ERPNext.ERPTypes.Quotation_lost_reason;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_partner;
using GizmoFort.Connector.ERPNext.ERPTypes.Sales_person;
using GizmoFort.Connector.ERPNext.ERPTypes.Supplier_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Target_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Terms_and_conditions;
using GizmoFort.Connector.ERPNext.ERPTypes.Territory;
using GizmoFort.Connector.ERPNext.ERPTypes.Uom;
using GizmoFort.Connector.ERPNext.ERPTypes.Uom_conversion_factor;
using GizmoFort.Connector.ERPNext.ERPTypes.Website_item_group;
using GizmoFort.Connector.ERPNext.ERPTypes.Shopping_cart_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Batch;
using GizmoFort.Connector.ERPNext.ERPTypes.Bin;
using GizmoFort.Connector.ERPNext.ERPTypes.Customs_tariff_number;
using GizmoFort.Connector.ERPNext.ERPTypes.Delivery_note;
using GizmoFort.Connector.ERPNext.ERPTypes.Delivery_note_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Delivery_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Delivery_stop;
using GizmoFort.Connector.ERPNext.ERPTypes.Delivery_trip;
using GizmoFort.Connector.ERPNext.ERPTypes.Item;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_alternative;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_attribute;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_attribute_value;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_barcode;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_customer_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_default;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_manufacturer;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_price;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_quality_inspection_parameter;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_reorder;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_supplier;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_tax;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_variant;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_variant_attribute;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_variant_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Item_website_specification;
using GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_purchase_receipt;
using GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_taxes_and_charges;
using GizmoFort.Connector.ERPNext.ERPTypes.Landed_cost_voucher;
using GizmoFort.Connector.ERPNext.ERPTypes.Manufacturer;
using GizmoFort.Connector.ERPNext.ERPTypes.Material_request;
using GizmoFort.Connector.ERPNext.ERPTypes.Material_request_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Packed_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Packing_slip;
using GizmoFort.Connector.ERPNext.ERPTypes.Packing_slip_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Pick_list;
using GizmoFort.Connector.ERPNext.ERPTypes.Pick_list_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Price_list;
using GizmoFort.Connector.ERPNext.ERPTypes.Price_list_country;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt;
using GizmoFort.Connector.ERPNext.ERPTypes.Purchase_receipt_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection_reading;
using GizmoFort.Connector.ERPNext.ERPTypes.Quality_inspection_template;
using GizmoFort.Connector.ERPNext.ERPTypes.Quick_stock_balance;
using GizmoFort.Connector.ERPNext.ERPTypes.Serial_no;
using GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Stock_entry_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Stock_ledger_entry;
using GizmoFort.Connector.ERPNext.ERPTypes.Stock_reconciliation;
using GizmoFort.Connector.ERPNext.ERPTypes.Stock_reconciliation_item;
using GizmoFort.Connector.ERPNext.ERPTypes.Stock_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Uom_category;
using GizmoFort.Connector.ERPNext.ERPTypes.Uom_conversion_detail;
using GizmoFort.Connector.ERPNext.ERPTypes.Variant_field;
using GizmoFort.Connector.ERPNext.ERPTypes.Warehouse;
using GizmoFort.Connector.ERPNext.ERPTypes.Warehouse_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Issue;
using GizmoFort.Connector.ERPNext.ERPTypes.Issue_priority;
using GizmoFort.Connector.ERPNext.ERPTypes.Issue_type;
using GizmoFort.Connector.ERPNext.ERPTypes.Service_day;
using GizmoFort.Connector.ERPNext.ERPTypes.Service_level;
using GizmoFort.Connector.ERPNext.ERPTypes.Service_level_agreement;
using GizmoFort.Connector.ERPNext.ERPTypes.Service_level_priority;
using GizmoFort.Connector.ERPNext.ERPTypes.Support_search_source;
using GizmoFort.Connector.ERPNext.ERPTypes.Support_settings;
using GizmoFort.Connector.ERPNext.ERPTypes.Warranty_claim;
using GizmoFort.Connector.ERPNext.ERPTypes.Rename_tool;
using GizmoFort.Connector.ERPNext.ERPTypes.Sms_log;

namespace GizmoFort.Connector.ERPNext.PublicInterfaces
{
    public class ERPNextServices
    {
        public ERPNextClient Client { get; }
        //public Academic_termService Academic_termService { get; }
        //public AccountService AccountService { get; }
        //public Accounting_dimensionService Accounting_dimensionService { get; }
        public AddressService AddressService { get; }
        //public CustomerService CustomerService { get; }
        //public ItemService ItemService { get; }
        //public WarehouseService WarehouseService { get; }

        //Add Under Class ERPNextServices 5/27/2020 8:37:28 AM
        public AccountService AccountService { get; }
        public At_austria_chart_templateService At_austria_chart_templateService { get; }
        public Be_l10nbe_chart_templateService Be_l10nbe_chart_templateService { get; }
        public Ch_l10nch_chart_templateService Ch_l10nch_chart_templateService { get; }
        public Cl_cl_chart_templateService Cl_cl_chart_templateService { get; }
        public Cn_l10n_chart_chinaService Cn_l10n_chart_chinaService { get; }
        public Co_vauxoo_mx_chart_templateService Co_vauxoo_mx_chart_templateService { get; }
        public Cr_account_chart_template_0Service Cr_account_chart_template_0Service { get; }
        public Cr_account_chart_template_xService Cr_account_chart_template_xService { get; }
        public De_l10n_de_chart_templateService De_l10n_de_chart_templateService { get; }
        public Ec_ec_chart_templateService Ec_ec_chart_templateService { get; }
        public Es_account_chart_template_commonService Es_account_chart_template_commonService { get; }
        public Et_l10n_etService Et_l10n_etService { get; }
        public Gr_l10n_gr_chart_templateService Gr_l10n_gr_chart_templateService { get; }
        public Hn_cuentas_plantillaService Hn_cuentas_plantillaService { get; }
        public Hr_l10n_hr_chart_template_rrifService Hr_l10n_hr_chart_template_rrifService { get; }
        public It_l10n_it_chart_template_genericService It_l10n_it_chart_template_genericService { get; }
        public Ma_l10n_kzc_temp_chartService Ma_l10n_kzc_temp_chartService { get; }
        public Pa_l10npa_chart_templateService Pa_l10npa_chart_templateService { get; }
        public Pe_pe_chart_templateService Pe_pe_chart_templateService { get; }
        public Pl_pl_chart_templateService Pl_pl_chart_templateService { get; }
        public Pt_pt_chart_templateService Pt_pt_chart_templateService { get; }
        public Ro_ro_chart_templateService Ro_ro_chart_templateService { get; }
        public Syscohada_syscohada_chart_templateService Syscohada_syscohada_chart_templateService { get; }
        public Th_chartService Th_chartService { get; }
        public Tr_l10ntr_tek_duzen_hesapService Tr_l10ntr_tek_duzen_hesapService { get; }
        public Uy_uy_chart_templateService Uy_uy_chart_templateService { get; }
        public Ve_ve_chart_template_amdService Ve_ve_chart_template_amdService { get; }
        public Ae_uae_chart_template_standardService Ae_uae_chart_template_standardService { get; }
        public Ar_chart_of_accountsService Ar_chart_of_accountsService { get; }
        public Br_planilha_de_contasService Br_planilha_de_contasService { get; }
        public Ca_plan_comptable_pour_les_provinces_francophonesService Ca_plan_comptable_pour_les_provinces_francophonesService { get; }
        public De_kontenplan_SKR03_gnucashService De_kontenplan_SKR03_gnucashService { get; }
        public De_kontenplan_SKR04Service De_kontenplan_SKR04Service { get; }
        public De_kontenplan_SKR04_with_account_numberService De_kontenplan_SKR04_with_account_numberService { get; }
        public El_salvador_standardService El_salvador_standardService { get; }
        public Fr_plan_comptable_generalService Fr_plan_comptable_generalService { get; }
        public Gt_cuentas_plantillaService Gt_cuentas_plantillaService { get; }
        public Hu_chart_of_accountsService Hu_chart_of_accountsService { get; }
        public Id_chart_of_accountsService Id_chart_of_accountsService { get; }
        public In_standard_chart_of_accountsService In_standard_chart_of_accountsService { get; }
        public Mx_plan_de_cuentasService Mx_plan_de_cuentasService { get; }
        public Ni_catalogo_de_cuentasService Ni_catalogo_de_cuentasService { get; }
        public Nl_grootboekschemaService Nl_grootboekschemaService { get; }
        public Sg_default_coaService Sg_default_coaService { get; }
        public Sg_fnb_coaService Sg_fnb_coaService { get; }
        public Tw_chart_of_accountsService Tw_chart_of_accountsService { get; }
        public Accounting_dimensionService Accounting_dimensionService { get; }
        public Accounting_dimension_detailService Accounting_dimension_detailService { get; }
        public Accounting_periodService Accounting_periodService { get; }
        public Accounts_settingsService Accounts_settingsService { get; }
        public Allowed_to_transact_withService Allowed_to_transact_withService { get; }
        public BankService BankService { get; }
        public Bank_accountService Bank_accountService { get; }
        public Bank_account_subtypeService Bank_account_subtypeService { get; }
        public Bank_account_typeService Bank_account_typeService { get; }
        public Bank_clearanceService Bank_clearanceService { get; }
        public Bank_clearance_detailService Bank_clearance_detailService { get; }
        public Bank_guaranteeService Bank_guaranteeService { get; }
        public Bank_statement_settingsService Bank_statement_settingsService { get; }
        public Bank_statement_settings_itemService Bank_statement_settings_itemService { get; }
        public Bank_statement_transaction_entryService Bank_statement_transaction_entryService { get; }
        public Bank_statement_transaction_invoice_itemService Bank_statement_transaction_invoice_itemService { get; }
        public Bank_statement_transaction_payment_itemService Bank_statement_transaction_payment_itemService { get; }
        public Bank_statement_transaction_settingsService Bank_statement_transaction_settingsService { get; }
        public Bank_statement_transaction_settings_itemService Bank_statement_transaction_settings_itemService { get; }
        public Bank_transactionService Bank_transactionService { get; }
        public Bank_transaction_mappingService Bank_transaction_mappingService { get; }
        public Bank_transaction_paymentsService Bank_transaction_paymentsService { get; }
        public BudgetService BudgetService { get; }
        public Budget_accountService Budget_accountService { get; }
        public Cashier_closingService Cashier_closingService { get; }
        public Cashier_closing_paymentsService Cashier_closing_paymentsService { get; }
        public Cash_flow_mapperService Cash_flow_mapperService { get; }
        public Cash_flow_mappingService Cash_flow_mappingService { get; }
        public Cash_flow_mapping_accountsService Cash_flow_mapping_accountsService { get; }
        public Cash_flow_mapping_templateService Cash_flow_mapping_templateService { get; }
        public Cash_flow_mapping_template_detailsService Cash_flow_mapping_template_detailsService { get; }
        public Chart_of_accounts_importerService Chart_of_accounts_importerService { get; }
        public Cheque_print_templateService Cheque_print_templateService { get; }
        public Closed_documentService Closed_documentService { get; }
        public Cost_centerService Cost_centerService { get; }
        public Coupon_codeService Coupon_codeService { get; }
        public C_formService C_formService { get; }
        public C_form_invoice_detailService C_form_invoice_detailService { get; }
        public Discounted_invoiceService Discounted_invoiceService { get; }
        public Exchange_rate_revaluationService Exchange_rate_revaluationService { get; }
        public Exchange_rate_revaluation_accountService Exchange_rate_revaluation_accountService { get; }
        public Finance_bookService Finance_bookService { get; }
        public Fiscal_yearService Fiscal_yearService { get; }
        public Fiscal_year_companyService Fiscal_year_companyService { get; }
        public Gl_entryService Gl_entryService { get; }
        public Gst_accountService Gst_accountService { get; }
        public Invoice_discountingService Invoice_discountingService { get; }
        public Item_tax_templateService Item_tax_templateService { get; }
        public Item_tax_template_detailService Item_tax_template_detailService { get; }
        public Journal_entryService Journal_entryService { get; }
        public Journal_entry_accountService Journal_entry_accountService { get; }
        public Journal_entry_templateService Journal_entry_templateService { get; }
        public Journal_entry_template_accountService Journal_entry_template_accountService { get; }
        public Loyalty_point_entryService Loyalty_point_entryService { get; }
        public Loyalty_point_entry_redemptionService Loyalty_point_entry_redemptionService { get; }
        public Loyalty_programService Loyalty_programService { get; }
        public Loyalty_program_collectionService Loyalty_program_collectionService { get; }
        public Mode_of_paymentService Mode_of_paymentService { get; }
        public Mode_of_payment_accountService Mode_of_payment_accountService { get; }
        public Monthly_distributionService Monthly_distributionService { get; }
        public Monthly_distribution_percentageService Monthly_distribution_percentageService { get; }
        public Opening_invoice_creation_toolService Opening_invoice_creation_toolService { get; }
        public Opening_invoice_creation_tool_itemService Opening_invoice_creation_tool_itemService { get; }
        public Party_accountService Party_accountService { get; }
        public Payment_entryService Payment_entryService { get; }
        public Payment_entry_deductionService Payment_entry_deductionService { get; }
        public Payment_entry_referenceService Payment_entry_referenceService { get; }
        public Payment_gateway_accountService Payment_gateway_accountService { get; }
        public Payment_orderService Payment_orderService { get; }
        public Payment_order_referenceService Payment_order_referenceService { get; }
        public Payment_reconciliationService Payment_reconciliationService { get; }
        public Payment_reconciliation_invoiceService Payment_reconciliation_invoiceService { get; }
        public Payment_reconciliation_paymentService Payment_reconciliation_paymentService { get; }
        public Payment_requestService Payment_requestService { get; }
        public Payment_scheduleService Payment_scheduleService { get; }
        public Payment_termService Payment_termService { get; }
        public Payment_terms_templateService Payment_terms_templateService { get; }
        public Payment_terms_template_detailService Payment_terms_template_detailService { get; }
        public Period_closing_voucherService Period_closing_voucherService { get; }
        public Pos_customer_groupService Pos_customer_groupService { get; }
        public Pos_fieldService Pos_fieldService { get; }
        public Pos_item_groupService Pos_item_groupService { get; }
        public Pos_profileService Pos_profileService { get; }
        public Pos_profile_userService Pos_profile_userService { get; }
        public Pos_settingsService Pos_settingsService { get; }
        public Pricing_ruleService Pricing_ruleService { get; }
        public Pricing_rule_brandService Pricing_rule_brandService { get; }
        public Pricing_rule_detailService Pricing_rule_detailService { get; }
        public Pricing_rule_item_codeService Pricing_rule_item_codeService { get; }
        public Pricing_rule_item_groupService Pricing_rule_item_groupService { get; }
        public Process_deferred_accountingService Process_deferred_accountingService { get; }
        public Promotional_schemeService Promotional_schemeService { get; }
        public Promotional_scheme_price_discountService Promotional_scheme_price_discountService { get; }
        public Promotional_scheme_product_discountService Promotional_scheme_product_discountService { get; }
        public Purchase_invoiceService Purchase_invoiceService { get; }
        public Purchase_invoice_advanceService Purchase_invoice_advanceService { get; }
        public Purchase_invoice_itemService Purchase_invoice_itemService { get; }
        public Purchase_taxes_and_chargesService Purchase_taxes_and_chargesService { get; }
        public Purchase_taxes_and_charges_templateService Purchase_taxes_and_charges_templateService { get; }
        public Salary_component_accountService Salary_component_accountService { get; }
        public Sales_invoiceService Sales_invoiceService { get; }
        public Sales_invoice_advanceService Sales_invoice_advanceService { get; }
        public Sales_invoice_itemService Sales_invoice_itemService { get; }
        public Sales_invoice_paymentService Sales_invoice_paymentService { get; }
        public Sales_invoice_timesheetService Sales_invoice_timesheetService { get; }
        public Sales_taxes_and_chargesService Sales_taxes_and_chargesService { get; }
        public Sales_taxes_and_charges_templateService Sales_taxes_and_charges_templateService { get; }
        public ShareholderService ShareholderService { get; }
        public Share_balanceService Share_balanceService { get; }
        public Share_transferService Share_transferService { get; }
        public Share_typeService Share_typeService { get; }
        public Shipping_ruleService Shipping_ruleService { get; }
        public Shipping_rule_conditionService Shipping_rule_conditionService { get; }
        public Shipping_rule_countryService Shipping_rule_countryService { get; }
        public SubscriptionService SubscriptionService { get; }
        public Subscription_invoiceService Subscription_invoiceService { get; }
        public Subscription_planService Subscription_planService { get; }
        public Subscription_plan_detailService Subscription_plan_detailService { get; }
        public Subscription_settingsService Subscription_settingsService { get; }
        public Tax_categoryService Tax_categoryService { get; }
        public Tax_ruleService Tax_ruleService { get; }
        public Tax_withholding_accountService Tax_withholding_accountService { get; }
        public Tax_withholding_categoryService Tax_withholding_categoryService { get; }
        public Tax_withholding_rateService Tax_withholding_rateService { get; }
        public Agriculture_analysis_criteriaService Agriculture_analysis_criteriaService { get; }
        public Agriculture_taskService Agriculture_taskService { get; }
        public CropService CropService { get; }
        public Crop_cycleService Crop_cycleService { get; }
        public Detected_diseaseService Detected_diseaseService { get; }
        public DiseaseService DiseaseService { get; }
        public FertilizerService FertilizerService { get; }
        public Fertilizer_contentService Fertilizer_contentService { get; }
        public Linked_locationService Linked_locationService { get; }
        public Linked_plant_analysisService Linked_plant_analysisService { get; }
        public Linked_soil_analysisService Linked_soil_analysisService { get; }
        public Linked_soil_textureService Linked_soil_textureService { get; }
        public Plant_analysisService Plant_analysisService { get; }
        public Plant_analysis_criteriaService Plant_analysis_criteriaService { get; }
        public Soil_analysisService Soil_analysisService { get; }
        public Soil_analysis_criteriaService Soil_analysis_criteriaService { get; }
        public Soil_textureService Soil_textureService { get; }
        public Soil_texture_criteriaService Soil_texture_criteriaService { get; }
        public Water_analysisService Water_analysisService { get; }
        public Water_analysis_criteriaService Water_analysis_criteriaService { get; }
        public WeatherService WeatherService { get; }
        public Weather_parameterService Weather_parameterService { get; }
        public AssetService AssetService { get; }
        public Asset_categoryService Asset_categoryService { get; }
        public Asset_category_accountService Asset_category_accountService { get; }
        public Asset_finance_bookService Asset_finance_bookService { get; }
        public Asset_maintenanceService Asset_maintenanceService { get; }
        public Asset_maintenance_logService Asset_maintenance_logService { get; }
        public Asset_maintenance_taskService Asset_maintenance_taskService { get; }
        public Asset_maintenance_teamService Asset_maintenance_teamService { get; }
        public Asset_movementService Asset_movementService { get; }
        public Asset_movement_itemService Asset_movement_itemService { get; }
        public Asset_repairService Asset_repairService { get; }
        public Asset_value_adjustmentService Asset_value_adjustmentService { get; }
        public Depreciation_scheduleService Depreciation_scheduleService { get; }
        //        public Linked_locationService Linked_locationService { get; }
        public LocationService LocationService { get; }
        public Maintenance_team_memberService Maintenance_team_memberService { get; }
        public Buying_settingsService Buying_settingsService { get; }
        public Purchase_orderService Purchase_orderService { get; }
        public Purchase_order_itemService Purchase_order_itemService { get; }
        public Purchase_order_item_suppliedService Purchase_order_item_suppliedService { get; }
        public Purchase_receipt_item_suppliedService Purchase_receipt_item_suppliedService { get; }
        public Request_for_quotationService Request_for_quotationService { get; }
        public Request_for_quotation_itemService Request_for_quotation_itemService { get; }
        public Request_for_quotation_supplierService Request_for_quotation_supplierService { get; }
        public SupplierService SupplierService { get; }
        public Supplier_quotationService Supplier_quotationService { get; }
        public Supplier_quotation_itemService Supplier_quotation_itemService { get; }
        public Supplier_scorecardService Supplier_scorecardService { get; }
        public Supplier_scorecard_criteriaService Supplier_scorecard_criteriaService { get; }
        public Supplier_scorecard_periodService Supplier_scorecard_periodService { get; }
        public Supplier_scorecard_scoring_criteriaService Supplier_scorecard_scoring_criteriaService { get; }
        public Supplier_scorecard_scoring_standingService Supplier_scorecard_scoring_standingService { get; }
        public Supplier_scorecard_scoring_variableService Supplier_scorecard_scoring_variableService { get; }
        public Supplier_scorecard_standingService Supplier_scorecard_standingService { get; }
        public Supplier_scorecard_variableService Supplier_scorecard_variableService { get; }
        public Call_logService Call_logService { get; }
        public Communication_mediumService Communication_mediumService { get; }
        public Communication_medium_timeslotService Communication_medium_timeslotService { get; }
        public AppointmentService AppointmentService { get; }
        public Appointment_booking_settingsService Appointment_booking_settingsService { get; }
        public Appointment_booking_slotsService Appointment_booking_slotsService { get; }
        public Availability_of_slotsService Availability_of_slotsService { get; }
        public Campaign_email_scheduleService Campaign_email_scheduleService { get; }
        public ContractService ContractService { get; }
        public Contract_fulfilment_checklistService Contract_fulfilment_checklistService { get; }
        public Contract_templateService Contract_templateService { get; }
        public Contract_template_fulfilment_termsService Contract_template_fulfilment_termsService { get; }
        public Email_campaignService Email_campaignService { get; }
        public LeadService LeadService { get; }
        public Linkedin_settingsService Linkedin_settingsService { get; }
        public Lost_reason_detailService Lost_reason_detailService { get; }
        public Market_segmentService Market_segmentService { get; }
        public OpportunityService OpportunityService { get; }
        public Opportunity_itemService Opportunity_itemService { get; }
        public Opportunity_lost_reasonService Opportunity_lost_reasonService { get; }
        public Opportunity_typeService Opportunity_typeService { get; }
        public Sales_stageService Sales_stageService { get; }
        public Social_media_postService Social_media_postService { get; }
        public Twitter_settingsService Twitter_settingsService { get; }
        public Academic_termService Academic_termService { get; }
        public Academic_yearService Academic_yearService { get; }
        public ArticleService ArticleService { get; }
        public Assessment_criteriaService Assessment_criteriaService { get; }
        public Assessment_criteria_groupService Assessment_criteria_groupService { get; }
        public Assessment_groupService Assessment_groupService { get; }
        public Assessment_planService Assessment_planService { get; }
        public Assessment_plan_criteriaService Assessment_plan_criteriaService { get; }
        public Assessment_resultService Assessment_resultService { get; }
        public Assessment_result_detailService Assessment_result_detailService { get; }
        public Assessment_result_toolService Assessment_result_toolService { get; }
        public Content_activityService Content_activityService { get; }
        public Content_questionService Content_questionService { get; }
        public CourseService CourseService { get; }
        public Course_activityService Course_activityService { get; }
        public Course_assessment_criteriaService Course_assessment_criteriaService { get; }
        public Course_contentService Course_contentService { get; }
        public Course_enrollmentService Course_enrollmentService { get; }
        public Course_scheduleService Course_scheduleService { get; }
        public Course_scheduling_toolService Course_scheduling_toolService { get; }
        public Course_topicService Course_topicService { get; }
        public Education_settingsService Education_settingsService { get; }
        public FeesService FeesService { get; }
        public Fee_categoryService Fee_categoryService { get; }
        public Fee_componentService Fee_componentService { get; }
        public Fee_scheduleService Fee_scheduleService { get; }
        public Fee_schedule_programService Fee_schedule_programService { get; }
        public Fee_schedule_student_groupService Fee_schedule_student_groupService { get; }
        public Fee_structureService Fee_structureService { get; }
        public Grading_scaleService Grading_scaleService { get; }
        public Grading_scale_intervalService Grading_scale_intervalService { get; }
        public GuardianService GuardianService { get; }
        public Guardian_interestService Guardian_interestService { get; }
        public Guardian_studentService Guardian_studentService { get; }
        public InstructorService InstructorService { get; }
        public Instructor_logService Instructor_logService { get; }
        public OptionsService OptionsService { get; }
        public ProgramService ProgramService { get; }
        public Program_courseService Program_courseService { get; }
        public Program_enrollmentService Program_enrollmentService { get; }
        public Program_enrollment_courseService Program_enrollment_courseService { get; }
        public Program_enrollment_feeService Program_enrollment_feeService { get; }
        public Program_enrollment_toolService Program_enrollment_toolService { get; }
        public Program_enrollment_tool_studentService Program_enrollment_tool_studentService { get; }
        public Program_feeService Program_feeService { get; }
        public QuestionService QuestionService { get; }
        public QuizService QuizService { get; }
        public Quiz_activityService Quiz_activityService { get; }
        public Quiz_questionService Quiz_questionService { get; }
        public Quiz_resultService Quiz_resultService { get; }
        public RoomService RoomService { get; }
        public School_houseService School_houseService { get; }
        public StudentService StudentService { get; }
        public Student_admissionService Student_admissionService { get; }
        public Student_admission_programService Student_admission_programService { get; }
        public Student_applicantService Student_applicantService { get; }
        public Student_attendanceService Student_attendanceService { get; }
        public Student_attendance_toolService Student_attendance_toolService { get; }
        public Student_batch_nameService Student_batch_nameService { get; }
        public Student_categoryService Student_categoryService { get; }
        public Student_groupService Student_groupService { get; }
        public Student_group_creation_toolService Student_group_creation_toolService { get; }
        public Student_group_creation_tool_courseService Student_group_creation_tool_courseService { get; }
        public Student_group_instructorService Student_group_instructorService { get; }
        public Student_group_studentService Student_group_studentService { get; }
        public Student_guardianService Student_guardianService { get; }
        public Student_languageService Student_languageService { get; }
        public Student_leave_applicationService Student_leave_applicationService { get; }
        public Student_logService Student_logService { get; }
        public Student_report_generation_toolService Student_report_generation_toolService { get; }
        public Student_siblingService Student_siblingService { get; }
        public Student_siblingsService Student_siblingsService { get; }
        public TopicService TopicService { get; }
        public Topic_contentService Topic_contentService { get; }
        public Amazon_mws_settingsService Amazon_mws_settingsService { get; }
        public Exotel_settingsService Exotel_settingsService { get; }
        public Gocardless_mandateService Gocardless_mandateService { get; }
        public Gocardless_settingsService Gocardless_settingsService { get; }
        public Plaid_settingsService Plaid_settingsService { get; }
        public Quickbooks_migratorService Quickbooks_migratorService { get; }
        public Shopify_logService Shopify_logService { get; }
        public Shopify_settingsService Shopify_settingsService { get; }
        public Shopify_customerService Shopify_customerService { get; }
        public Shopify_itemService Shopify_itemService { get; }
        public Shopify_orderService Shopify_orderService { get; }
        public Shopify_tax_accountService Shopify_tax_accountService { get; }
        public Shopify_webhook_detailService Shopify_webhook_detailService { get; }
        public Tally_migrationService Tally_migrationService { get; }
        public Woocommerce_settingsService Woocommerce_settingsService { get; }
        public AntibioticService AntibioticService { get; }
        public Appointment_typeService Appointment_typeService { get; }
        public Body_partService Body_partService { get; }
        public Body_part_linkService Body_part_linkService { get; }
        public Clinical_procedureService Clinical_procedureService { get; }
        public Clinical_procedure_itemService Clinical_procedure_itemService { get; }
        public Clinical_procedure_templateService Clinical_procedure_templateService { get; }
        public Codification_tableService Codification_tableService { get; }
        public ComplaintService ComplaintService { get; }
        public DiagnosisService DiagnosisService { get; }
        public Dosage_formService Dosage_formService { get; }
        public Dosage_strengthService Dosage_strengthService { get; }
        public Drug_prescriptionService Drug_prescriptionService { get; }
        public ExerciseService ExerciseService { get; }
        public Exercise_difficulty_levelService Exercise_difficulty_levelService { get; }
        public Exercise_typeService Exercise_typeService { get; }
        public Exercise_type_stepService Exercise_type_stepService { get; }
        public Fee_validityService Fee_validityService { get; }
        public Fee_validity_referenceService Fee_validity_referenceService { get; }
        public Healthcare_practitionerService Healthcare_practitionerService { get; }
        public Healthcare_schedule_time_slotService Healthcare_schedule_time_slotService { get; }
        public Healthcare_service_unitService Healthcare_service_unitService { get; }
        public Healthcare_service_unit_typeService Healthcare_service_unit_typeService { get; }
        public Healthcare_settingsService Healthcare_settingsService { get; }
        public Inpatient_occupancyService Inpatient_occupancyService { get; }
        public Inpatient_recordService Inpatient_recordService { get; }
        public Lab_prescriptionService Lab_prescriptionService { get; }
        public Lab_testService Lab_testService { get; }
        public Lab_test_groupsService Lab_test_groupsService { get; }
        public Lab_test_sampleService Lab_test_sampleService { get; }
        public Lab_test_templateService Lab_test_templateService { get; }
        public Lab_test_uomService Lab_test_uomService { get; }
        public Medical_codeService Medical_codeService { get; }
        public Medical_code_standardService Medical_code_standardService { get; }
        public Medical_departmentService Medical_departmentService { get; }
        public Normal_test_itemsService Normal_test_itemsService { get; }
        public Normal_test_templateService Normal_test_templateService { get; }
        public PatientService PatientService { get; }
        public Patient_appointmentService Patient_appointmentService { get; }
        public Patient_assessmentService Patient_assessmentService { get; }
        public Patient_assessment_detailService Patient_assessment_detailService { get; }
        public Patient_assessment_parameterService Patient_assessment_parameterService { get; }
        public Patient_assessment_sheetService Patient_assessment_sheetService { get; }
        public Patient_assessment_templateService Patient_assessment_templateService { get; }
        public Patient_encounterService Patient_encounterService { get; }
        public Patient_encounter_diagnosisService Patient_encounter_diagnosisService { get; }
        public Patient_encounter_symptomService Patient_encounter_symptomService { get; }
        public Patient_medical_recordService Patient_medical_recordService { get; }
        public Patient_relationService Patient_relationService { get; }
        public Practitioner_scheduleService Practitioner_scheduleService { get; }
        public Practitioner_service_unit_scheduleService Practitioner_service_unit_scheduleService { get; }
        public Prescription_dosageService Prescription_dosageService { get; }
        public Prescription_durationService Prescription_durationService { get; }
        public Procedure_prescriptionService Procedure_prescriptionService { get; }
        public Sample_collectionService Sample_collectionService { get; }
        public SensitivityService SensitivityService { get; }
        public Sensitivity_test_itemsService Sensitivity_test_itemsService { get; }
        public Special_test_itemsService Special_test_itemsService { get; }
        public Special_test_templateService Special_test_templateService { get; }
        public Therapy_planService Therapy_planService { get; }
        public Therapy_plan_detailService Therapy_plan_detailService { get; }
        public Therapy_sessionService Therapy_sessionService { get; }
        public Therapy_typeService Therapy_typeService { get; }
        public Vital_signsService Vital_signsService { get; }
        public Hotel_roomService Hotel_roomService { get; }
        public Hotel_room_amenityService Hotel_room_amenityService { get; }
        public Hotel_room_packageService Hotel_room_packageService { get; }
        public Hotel_room_pricingService Hotel_room_pricingService { get; }
        public Hotel_room_pricing_itemService Hotel_room_pricing_itemService { get; }
        public Hotel_room_pricing_packageService Hotel_room_pricing_packageService { get; }
        public Hotel_room_reservationService Hotel_room_reservationService { get; }
        public Hotel_room_reservation_itemService Hotel_room_reservation_itemService { get; }
        public Hotel_room_typeService Hotel_room_typeService { get; }
        public Hotel_settingsService Hotel_settingsService { get; }
        public Additional_salaryService Additional_salaryService { get; }
        public Appointment_letterService Appointment_letterService { get; }
        public Appointment_letter_contentService Appointment_letter_contentService { get; }
        public Appointment_letter_templateService Appointment_letter_templateService { get; }
        public AppraisalService AppraisalService { get; }
        public Appraisal_goalService Appraisal_goalService { get; }
        public Appraisal_templateService Appraisal_templateService { get; }
        public Appraisal_template_goalService Appraisal_template_goalService { get; }
        public AttendanceService AttendanceService { get; }
        public Attendance_requestService Attendance_requestService { get; }
        public BranchService BranchService { get; }
        public Compensatory_leave_requestService Compensatory_leave_requestService { get; }
        public Daily_work_summaryService Daily_work_summaryService { get; }
        public Daily_work_summary_groupService Daily_work_summary_groupService { get; }
        public Daily_work_summary_group_userService Daily_work_summary_group_userService { get; }
        public DepartmentService DepartmentService { get; }
        public Department_approverService Department_approverService { get; }
        public DesignationService DesignationService { get; }
        public Designation_skillService Designation_skillService { get; }
        public DriverService DriverService { get; }
        public Driving_license_categoryService Driving_license_categoryService { get; }
        public EmployeeService EmployeeService { get; }
        public Employee_advanceService Employee_advanceService { get; }
        public Employee_attendance_toolService Employee_attendance_toolService { get; }
        public Employee_benefit_applicationService Employee_benefit_applicationService { get; }
        public Employee_benefit_application_detailService Employee_benefit_application_detailService { get; }
        public Employee_benefit_claimService Employee_benefit_claimService { get; }
        public Employee_boarding_activityService Employee_boarding_activityService { get; }
        public Employee_checkinService Employee_checkinService { get; }
        public Employee_educationService Employee_educationService { get; }
        public Employee_external_work_historyService Employee_external_work_historyService { get; }
        public Employee_gradeService Employee_gradeService { get; }
        public Employee_groupService Employee_groupService { get; }
        public Employee_group_tableService Employee_group_tableService { get; }
        public Employee_health_insuranceService Employee_health_insuranceService { get; }
        public Employee_incentiveService Employee_incentiveService { get; }
        public Employee_internal_work_historyService Employee_internal_work_historyService { get; }
        public Employee_onboardingService Employee_onboardingService { get; }
        public Employee_onboarding_activityService Employee_onboarding_activityService { get; }
        public Employee_onboarding_templateService Employee_onboarding_templateService { get; }
        public Employee_other_incomeService Employee_other_incomeService { get; }
        public Employee_promotionService Employee_promotionService { get; }
        public Employee_property_historyService Employee_property_historyService { get; }
        public Employee_separationService Employee_separationService { get; }
        public Employee_separation_templateService Employee_separation_templateService { get; }
        public Employee_skillService Employee_skillService { get; }
        public Employee_skill_mapService Employee_skill_mapService { get; }
        public Employee_tax_exemption_categoryService Employee_tax_exemption_categoryService { get; }
        public Employee_tax_exemption_declarationService Employee_tax_exemption_declarationService { get; }
        public Employee_tax_exemption_declaration_categoryService Employee_tax_exemption_declaration_categoryService { get; }
        public Employee_tax_exemption_proof_submissionService Employee_tax_exemption_proof_submissionService { get; }
        public Employee_tax_exemption_proof_submission_detailService Employee_tax_exemption_proof_submission_detailService { get; }
        public Employee_tax_exemption_sub_categoryService Employee_tax_exemption_sub_categoryService { get; }
        public Employee_trainingService Employee_trainingService { get; }
        public Employee_transferService Employee_transferService { get; }
        public Employee_transfer_propertyService Employee_transfer_propertyService { get; }
        public Employment_typeService Employment_typeService { get; }
        public Expense_claimService Expense_claimService { get; }
        public Expense_claim_accountService Expense_claim_accountService { get; }
        public Expense_claim_advanceService Expense_claim_advanceService { get; }
        public Expense_claim_detailService Expense_claim_detailService { get; }
        public Expense_claim_typeService Expense_claim_typeService { get; }
        public Expense_taxes_and_chargesService Expense_taxes_and_chargesService { get; }
        public HolidayService HolidayService { get; }
        public Holiday_listService Holiday_listService { get; }
        public Hr_settingsService Hr_settingsService { get; }
        public Identification_document_typeService Identification_document_typeService { get; }
        public Income_tax_slabService Income_tax_slabService { get; }
        public Income_tax_slab_other_chargesService Income_tax_slab_other_chargesService { get; }
        public InterestService InterestService { get; }
        public Job_applicantService Job_applicantService { get; }
        public Job_applicant_sourceService Job_applicant_sourceService { get; }
        public Job_offerService Job_offerService { get; }
        public Job_offer_termService Job_offer_termService { get; }
        public Job_openingService Job_openingService { get; }
        public Leave_allocationService Leave_allocationService { get; }
        public Leave_applicationService Leave_applicationService { get; }
        public Leave_block_listService Leave_block_listService { get; }
        public Leave_block_list_allowService Leave_block_list_allowService { get; }
        public Leave_block_list_dateService Leave_block_list_dateService { get; }
        public Leave_control_panelService Leave_control_panelService { get; }
        public Leave_encashmentService Leave_encashmentService { get; }
        public Leave_ledger_entryService Leave_ledger_entryService { get; }
        public Leave_periodService Leave_periodService { get; }
        public Leave_policyService Leave_policyService { get; }
        public Leave_policy_detailService Leave_policy_detailService { get; }
        public Leave_typeService Leave_typeService { get; }
        public Offer_termService Offer_termService { get; }
        public Payroll_employee_detailService Payroll_employee_detailService { get; }
        public Payroll_entryService Payroll_entryService { get; }
        public Payroll_periodService Payroll_periodService { get; }
        public Payroll_period_dateService Payroll_period_dateService { get; }
        public Purpose_of_travelService Purpose_of_travelService { get; }
        public Retention_bonusService Retention_bonusService { get; }
        public Salary_componentService Salary_componentService { get; }
        public Salary_detailService Salary_detailService { get; }
        public Salary_slipService Salary_slipService { get; }
        public Salary_slip_timesheetService Salary_slip_timesheetService { get; }
        public Salary_structureService Salary_structureService { get; }
        public Salary_structure_assignmentService Salary_structure_assignmentService { get; }
        public Shift_assignmentService Shift_assignmentService { get; }
        public Shift_requestService Shift_requestService { get; }
        public Shift_typeService Shift_typeService { get; }
        public SkillService SkillService { get; }
        public Staffing_planService Staffing_planService { get; }
        public Staffing_plan_detailService Staffing_plan_detailService { get; }
        public Taxable_salary_slabService Taxable_salary_slabService { get; }
        public Training_eventService Training_eventService { get; }
        public Training_event_employeeService Training_event_employeeService { get; }
        public Training_feedbackService Training_feedbackService { get; }
        public Training_programService Training_programService { get; }
        public Training_resultService Training_resultService { get; }
        public Training_result_employeeService Training_result_employeeService { get; }
        public Travel_itineraryService Travel_itineraryService { get; }
        public Travel_requestService Travel_requestService { get; }
        public Travel_request_costingService Travel_request_costingService { get; }
        public Upload_attendanceService Upload_attendanceService { get; }
        public VehicleService VehicleService { get; }
        public Vehicle_logService Vehicle_logService { get; }
        public Vehicle_serviceService Vehicle_serviceService { get; }
        public Hub_tracked_itemService Hub_tracked_itemService { get; }
        public Hub_userService Hub_userService { get; }
        public Hub_usersService Hub_usersService { get; }
        public Marketplace_settingsService Marketplace_settingsService { get; }
        public LoanService LoanService { get; }
        public Loan_applicationService Loan_applicationService { get; }
        public Loan_disbursementService Loan_disbursementService { get; }
        public Loan_interest_accrualService Loan_interest_accrualService { get; }
        public Loan_repaymentService Loan_repaymentService { get; }
        public Loan_repayment_detailService Loan_repayment_detailService { get; }
        public Loan_securityService Loan_securityService { get; }
        public Loan_security_pledgeService Loan_security_pledgeService { get; }
        public Loan_security_priceService Loan_security_priceService { get; }
        public Loan_security_shortfallService Loan_security_shortfallService { get; }
        public Loan_security_typeService Loan_security_typeService { get; }
        public Loan_security_unpledgeService Loan_security_unpledgeService { get; }
        public Loan_typeService Loan_typeService { get; }
        public PledgeService PledgeService { get; }
        public Process_loan_interest_accrualService Process_loan_interest_accrualService { get; }
        public Process_loan_security_shortfallService Process_loan_security_shortfallService { get; }
        public Proposed_pledgeService Proposed_pledgeService { get; }
        public Repayment_scheduleService Repayment_scheduleService { get; }
        public Salary_slip_loanService Salary_slip_loanService { get; }
        public Sanctioned_loan_amountService Sanctioned_loan_amountService { get; }
        public UnpledgeService UnpledgeService { get; }
        public Maintenance_scheduleService Maintenance_scheduleService { get; }
        public Maintenance_schedule_detailService Maintenance_schedule_detailService { get; }
        public Maintenance_schedule_itemService Maintenance_schedule_itemService { get; }
        public Maintenance_visitService Maintenance_visitService { get; }
        public Maintenance_visit_purposeService Maintenance_visit_purposeService { get; }
        public Blanket_orderService Blanket_orderService { get; }
        public Blanket_order_itemService Blanket_order_itemService { get; }
        public BomService BomService { get; }
        public Bom_explosion_itemService Bom_explosion_itemService { get; }
        public Bom_itemService Bom_itemService { get; }
        public Bom_operationService Bom_operationService { get; }
        public Bom_scrap_itemService Bom_scrap_itemService { get; }
        public Bom_update_toolService Bom_update_toolService { get; }
        public Bom_website_itemService Bom_website_itemService { get; }
        public Bom_website_operationService Bom_website_operationService { get; }
        public Downtime_entryService Downtime_entryService { get; }
        public Job_cardService Job_cardService { get; }
        public Job_card_itemService Job_card_itemService { get; }
        public Job_card_time_logService Job_card_time_logService { get; }
        public Manufacturing_settingsService Manufacturing_settingsService { get; }
        public Material_request_plan_itemService Material_request_plan_itemService { get; }
        public OperationService OperationService { get; }
        public Production_planService Production_planService { get; }
        public Production_plan_itemService Production_plan_itemService { get; }
        public Production_plan_material_requestService Production_plan_material_requestService { get; }
        public Production_plan_material_request_warehouseService Production_plan_material_request_warehouseService { get; }
        public Production_plan_sales_orderService Production_plan_sales_orderService { get; }
        public RoutingService RoutingService { get; }
        public WorkstationService WorkstationService { get; }
        public Workstation_working_hourService Workstation_working_hourService { get; }
        public Work_orderService Work_orderService { get; }
        public Work_order_itemService Work_order_itemService { get; }
        public Work_order_operationService Work_order_operationService { get; }
        public Certification_applicationService Certification_applicationService { get; }
        public Certified_consultantService Certified_consultantService { get; }
        public ChapterService ChapterService { get; }
        public Chapter_memberService Chapter_memberService { get; }
        public DonorService DonorService { get; }
        public Donor_typeService Donor_typeService { get; }
        public Grant_applicationService Grant_applicationService { get; }
        public MemberService MemberService { get; }
        public MembershipService MembershipService { get; }
        public Membership_settingsService Membership_settingsService { get; }
        public Membership_typeService Membership_typeService { get; }
        public VolunteerService VolunteerService { get; }
        public Volunteer_skillService Volunteer_skillService { get; }
        public Volunteer_typeService Volunteer_typeService { get; }
        public HomepageService HomepageService { get; }
        public Homepage_featured_productService Homepage_featured_productService { get; }
        public Homepage_sectionService Homepage_sectionService { get; }
        public Homepage_section_cardService Homepage_section_cardService { get; }
        public Products_settingsService Products_settingsService { get; }
        public Website_attributeService Website_attributeService { get; }
        public Website_filter_fieldService Website_filter_fieldService { get; }
        public Activity_costService Activity_costService { get; }
        public Activity_typeService Activity_typeService { get; }
        public Dependent_taskService Dependent_taskService { get; }
        public ProjectService ProjectService { get; }
        public Projects_settingsService Projects_settingsService { get; }
        public Project_templateService Project_templateService { get; }
        public Project_template_taskService Project_template_taskService { get; }
        public Project_typeService Project_typeService { get; }
        public Project_updateService Project_updateService { get; }
        public Project_userService Project_userService { get; }
        public TaskService TaskService { get; }
        public Task_depends_onService Task_depends_onService { get; }
        public Task_typeService Task_typeService { get; }
        public TimesheetService TimesheetService { get; }
        public Timesheet_detailService Timesheet_detailService { get; }
        public Quality_actionService Quality_actionService { get; }
        public Quality_action_resolutionService Quality_action_resolutionService { get; }
        public Quality_feedbackService Quality_feedbackService { get; }
        public Quality_feedback_parameterService Quality_feedback_parameterService { get; }
        public Quality_feedback_templateService Quality_feedback_templateService { get; }
        public Quality_feedback_template_parameterService Quality_feedback_template_parameterService { get; }
        public Quality_goalService Quality_goalService { get; }
        public Quality_goal_objectiveService Quality_goal_objectiveService { get; }
        public Quality_meetingService Quality_meetingService { get; }
        public Quality_meeting_agendaService Quality_meeting_agendaService { get; }
        public Quality_meeting_minutesService Quality_meeting_minutesService { get; }
        public Quality_procedureService Quality_procedureService { get; }
        public Quality_procedure_processService Quality_procedure_processService { get; }
        public Quality_reviewService Quality_reviewService { get; }
        public Quality_review_objectiveService Quality_review_objectiveService { get; }
        public Datev_settingsService Datev_settingsService { get; }
        public Gstr_3b_reportService Gstr_3b_reportService { get; }
        public Gst_hsn_codeService Gst_hsn_codeService { get; }
        public Gst_settingsService Gst_settingsService { get; }
        public Import_supplier_invoiceService Import_supplier_invoiceService { get; }
        public Lower_deduction_certificateService Lower_deduction_certificateService { get; }
        public RestaurantService RestaurantService { get; }
        public Restaurant_menuService Restaurant_menuService { get; }
        public Restaurant_menu_itemService Restaurant_menu_itemService { get; }
        public Restaurant_order_entryService Restaurant_order_entryService { get; }
        public Restaurant_order_entry_itemService Restaurant_order_entry_itemService { get; }
        public Restaurant_reservationService Restaurant_reservationService { get; }
        public Restaurant_tableService Restaurant_tableService { get; }
        public CampaignService CampaignService { get; }
        public CustomerService CustomerService { get; }
        public Customer_credit_limitService Customer_credit_limitService { get; }
        public Industry_typeService Industry_typeService { get; }
        public Installation_noteService Installation_noteService { get; }
        public Installation_note_itemService Installation_note_itemService { get; }
        public Lead_sourceService Lead_sourceService { get; }
        public Pos_closing_voucherService Pos_closing_voucherService { get; }
        public Pos_closing_voucher_detailsService Pos_closing_voucher_detailsService { get; }
        public Pos_closing_voucher_invoicesService Pos_closing_voucher_invoicesService { get; }
        public Pos_closing_voucher_taxesService Pos_closing_voucher_taxesService { get; }
        public Product_bundleService Product_bundleService { get; }
        public Product_bundle_itemService Product_bundle_itemService { get; }
        public QuotationService QuotationService { get; }
        public Quotation_itemService Quotation_itemService { get; }
        public Sales_orderService Sales_orderService { get; }
        public Sales_order_itemService Sales_order_itemService { get; }
        public Sales_partner_typeService Sales_partner_typeService { get; }
        public Sales_teamService Sales_teamService { get; }
        public Selling_settingsService Selling_settingsService { get; }
        public Sms_centerService Sms_centerService { get; }
        public Authorization_controlService Authorization_controlService { get; }
        public Authorization_ruleService Authorization_ruleService { get; }
        public BrandService BrandService { get; }
        public CompanyService CompanyService { get; }
        public Currency_exchangeService Currency_exchangeService { get; }
        public Customer_groupService Customer_groupService { get; }
        public Email_digestService Email_digestService { get; }
        public Global_defaultsService Global_defaultsService { get; }
        public Item_groupService Item_groupService { get; }
        public Naming_seriesService Naming_seriesService { get; }
        public Party_typeService Party_typeService { get; }
        public Print_headingService Print_headingService { get; }
        public Quotation_lost_reasonService Quotation_lost_reasonService { get; }
        public Sales_partnerService Sales_partnerService { get; }
        public Sales_personService Sales_personService { get; }
        public Supplier_groupService Supplier_groupService { get; }
        public Target_detailService Target_detailService { get; }
        public Terms_and_conditionsService Terms_and_conditionsService { get; }
        public TerritoryService TerritoryService { get; }
        public UomService UomService { get; }
        public Uom_conversion_factorService Uom_conversion_factorService { get; }
        public Website_item_groupService Website_item_groupService { get; }
        public Shopping_cart_settingsService Shopping_cart_settingsService { get; }
        public BatchService BatchService { get; }
        public BinService BinService { get; }
        public Customs_tariff_numberService Customs_tariff_numberService { get; }
        public Delivery_noteService Delivery_noteService { get; }
        public Delivery_note_itemService Delivery_note_itemService { get; }
        public Delivery_settingsService Delivery_settingsService { get; }
        public Delivery_stopService Delivery_stopService { get; }
        public Delivery_tripService Delivery_tripService { get; }
        public ItemService ItemService { get; }
        public Item_alternativeService Item_alternativeService { get; }
        public Item_attributeService Item_attributeService { get; }
        public Item_attribute_valueService Item_attribute_valueService { get; }
        public Item_barcodeService Item_barcodeService { get; }
        public Item_customer_detailService Item_customer_detailService { get; }
        public Item_defaultService Item_defaultService { get; }
        public Item_manufacturerService Item_manufacturerService { get; }
        public Item_priceService Item_priceService { get; }
        public Item_quality_inspection_parameterService Item_quality_inspection_parameterService { get; }
        public Item_reorderService Item_reorderService { get; }
        public Item_supplierService Item_supplierService { get; }
        public Item_taxService Item_taxService { get; }
        public Item_variantService Item_variantService { get; }
        public Item_variant_attributeService Item_variant_attributeService { get; }
        public Item_variant_settingsService Item_variant_settingsService { get; }
        public Item_website_specificationService Item_website_specificationService { get; }
        public Landed_cost_itemService Landed_cost_itemService { get; }
        public Landed_cost_purchase_receiptService Landed_cost_purchase_receiptService { get; }
        public Landed_cost_taxes_and_chargesService Landed_cost_taxes_and_chargesService { get; }
        public Landed_cost_voucherService Landed_cost_voucherService { get; }
        public ManufacturerService ManufacturerService { get; }
        public Material_requestService Material_requestService { get; }
        public Material_request_itemService Material_request_itemService { get; }
        public Packed_itemService Packed_itemService { get; }
        public Packing_slipService Packing_slipService { get; }
        public Packing_slip_itemService Packing_slip_itemService { get; }
        public Pick_listService Pick_listService { get; }
        public Pick_list_itemService Pick_list_itemService { get; }
        public Price_listService Price_listService { get; }
        public Price_list_countryService Price_list_countryService { get; }
        public Purchase_receiptService Purchase_receiptService { get; }
        public Purchase_receipt_itemService Purchase_receipt_itemService { get; }
        public Quality_inspectionService Quality_inspectionService { get; }
        public Quality_inspection_readingService Quality_inspection_readingService { get; }
        public Quality_inspection_templateService Quality_inspection_templateService { get; }
        public Quick_stock_balanceService Quick_stock_balanceService { get; }
        public Serial_noService Serial_noService { get; }
        public Stock_entryService Stock_entryService { get; }
        public Stock_entry_detailService Stock_entry_detailService { get; }
        public Stock_entry_typeService Stock_entry_typeService { get; }
        public Stock_ledger_entryService Stock_ledger_entryService { get; }
        public Stock_reconciliationService Stock_reconciliationService { get; }
        public Stock_reconciliation_itemService Stock_reconciliation_itemService { get; }
        public Stock_settingsService Stock_settingsService { get; }
        public Uom_categoryService Uom_categoryService { get; }
        public Uom_conversion_detailService Uom_conversion_detailService { get; }
        public Variant_fieldService Variant_fieldService { get; }
        public WarehouseService WarehouseService { get; }
        public Warehouse_typeService Warehouse_typeService { get; }
        public IssueService IssueService { get; }
        public Issue_priorityService Issue_priorityService { get; }
        public Issue_typeService Issue_typeService { get; }
        public Service_dayService Service_dayService { get; }
        public Service_levelService Service_levelService { get; }
        public Service_level_agreementService Service_level_agreementService { get; }
        public Service_level_priorityService Service_level_priorityService { get; }
        public Support_search_sourceService Support_search_sourceService { get; }
        public Support_settingsService Support_settingsService { get; }
        public Warranty_claimService Warranty_claimService { get; }
        public Rename_toolService Rename_toolService { get; }
        public Sms_logService Sms_logService { get; }

        public ERPNextServices(string domain, string username, string password)
        {
            this.Client = new ERPNextClient(domain, username, password);
            //this.Academic_termService = new Academic_termService(Client);
            //this.AccountService = new AccountService(Client);
            //this.Accounting_dimensionService = new Accounting_dimensionService(Client);
            this.AddressService = new AddressService(Client);
            //this.CustomerService = new CustomerService(Client);
            //this.ItemService = new ItemService(Client);
            //this.WarehouseService = new WarehouseService(Client);

            //Add Under ErpnextServices() 5/27/2020 8:46:13 AM
            this.AccountService = new AccountService(Client);
            this.At_austria_chart_templateService = new At_austria_chart_templateService(Client);
            this.Be_l10nbe_chart_templateService = new Be_l10nbe_chart_templateService(Client);
            this.Ch_l10nch_chart_templateService = new Ch_l10nch_chart_templateService(Client);
            this.Cl_cl_chart_templateService = new Cl_cl_chart_templateService(Client);
            this.Cn_l10n_chart_chinaService = new Cn_l10n_chart_chinaService(Client);
            this.Co_vauxoo_mx_chart_templateService = new Co_vauxoo_mx_chart_templateService(Client);
            this.Cr_account_chart_template_0Service = new Cr_account_chart_template_0Service(Client);
            this.Cr_account_chart_template_xService = new Cr_account_chart_template_xService(Client);
            this.De_l10n_de_chart_templateService = new De_l10n_de_chart_templateService(Client);
            this.Ec_ec_chart_templateService = new Ec_ec_chart_templateService(Client);
            this.Es_account_chart_template_commonService = new Es_account_chart_template_commonService(Client);
            this.Et_l10n_etService = new Et_l10n_etService(Client);
            this.Gr_l10n_gr_chart_templateService = new Gr_l10n_gr_chart_templateService(Client);
            this.Hn_cuentas_plantillaService = new Hn_cuentas_plantillaService(Client);
            this.Hr_l10n_hr_chart_template_rrifService = new Hr_l10n_hr_chart_template_rrifService(Client);
            this.It_l10n_it_chart_template_genericService = new It_l10n_it_chart_template_genericService(Client);
            this.Ma_l10n_kzc_temp_chartService = new Ma_l10n_kzc_temp_chartService(Client);
            this.Pa_l10npa_chart_templateService = new Pa_l10npa_chart_templateService(Client);
            this.Pe_pe_chart_templateService = new Pe_pe_chart_templateService(Client);
            this.Pl_pl_chart_templateService = new Pl_pl_chart_templateService(Client);
            this.Pt_pt_chart_templateService = new Pt_pt_chart_templateService(Client);
            this.Ro_ro_chart_templateService = new Ro_ro_chart_templateService(Client);
            this.Syscohada_syscohada_chart_templateService = new Syscohada_syscohada_chart_templateService(Client);
            this.Th_chartService = new Th_chartService(Client);
            this.Tr_l10ntr_tek_duzen_hesapService = new Tr_l10ntr_tek_duzen_hesapService(Client);
            this.Uy_uy_chart_templateService = new Uy_uy_chart_templateService(Client);
            this.Ve_ve_chart_template_amdService = new Ve_ve_chart_template_amdService(Client);
            this.Ae_uae_chart_template_standardService = new Ae_uae_chart_template_standardService(Client);
            this.Ar_chart_of_accountsService = new Ar_chart_of_accountsService(Client);
            this.Br_planilha_de_contasService = new Br_planilha_de_contasService(Client);
            this.Ca_plan_comptable_pour_les_provinces_francophonesService = new Ca_plan_comptable_pour_les_provinces_francophonesService(Client);
            this.De_kontenplan_SKR03_gnucashService = new De_kontenplan_SKR03_gnucashService(Client);
            this.De_kontenplan_SKR04Service = new De_kontenplan_SKR04Service(Client);
            this.De_kontenplan_SKR04_with_account_numberService = new De_kontenplan_SKR04_with_account_numberService(Client);
            this.El_salvador_standardService = new El_salvador_standardService(Client);
            this.Fr_plan_comptable_generalService = new Fr_plan_comptable_generalService(Client);
            this.Gt_cuentas_plantillaService = new Gt_cuentas_plantillaService(Client);
            this.Hu_chart_of_accountsService = new Hu_chart_of_accountsService(Client);
            this.Id_chart_of_accountsService = new Id_chart_of_accountsService(Client);
            this.In_standard_chart_of_accountsService = new In_standard_chart_of_accountsService(Client);
            this.Mx_plan_de_cuentasService = new Mx_plan_de_cuentasService(Client);
            this.Ni_catalogo_de_cuentasService = new Ni_catalogo_de_cuentasService(Client);
            this.Nl_grootboekschemaService = new Nl_grootboekschemaService(Client);
            this.Sg_default_coaService = new Sg_default_coaService(Client);
            this.Sg_fnb_coaService = new Sg_fnb_coaService(Client);
            this.Tw_chart_of_accountsService = new Tw_chart_of_accountsService(Client);
            this.Accounting_dimensionService = new Accounting_dimensionService(Client);
            this.Accounting_dimension_detailService = new Accounting_dimension_detailService(Client);
            this.Accounting_periodService = new Accounting_periodService(Client);
            this.Accounts_settingsService = new Accounts_settingsService(Client);
            this.Allowed_to_transact_withService = new Allowed_to_transact_withService(Client);
            this.BankService = new BankService(Client);
            this.Bank_accountService = new Bank_accountService(Client);
            this.Bank_account_subtypeService = new Bank_account_subtypeService(Client);
            this.Bank_account_typeService = new Bank_account_typeService(Client);
            this.Bank_clearanceService = new Bank_clearanceService(Client);
            this.Bank_clearance_detailService = new Bank_clearance_detailService(Client);
            this.Bank_guaranteeService = new Bank_guaranteeService(Client);
            this.Bank_statement_settingsService = new Bank_statement_settingsService(Client);
            this.Bank_statement_settings_itemService = new Bank_statement_settings_itemService(Client);
            this.Bank_statement_transaction_entryService = new Bank_statement_transaction_entryService(Client);
            this.Bank_statement_transaction_invoice_itemService = new Bank_statement_transaction_invoice_itemService(Client);
            this.Bank_statement_transaction_payment_itemService = new Bank_statement_transaction_payment_itemService(Client);
            this.Bank_statement_transaction_settingsService = new Bank_statement_transaction_settingsService(Client);
            this.Bank_statement_transaction_settings_itemService = new Bank_statement_transaction_settings_itemService(Client);
            this.Bank_transactionService = new Bank_transactionService(Client);
            this.Bank_transaction_mappingService = new Bank_transaction_mappingService(Client);
            this.Bank_transaction_paymentsService = new Bank_transaction_paymentsService(Client);
            this.BudgetService = new BudgetService(Client);
            this.Budget_accountService = new Budget_accountService(Client);
            this.Cashier_closingService = new Cashier_closingService(Client);
            this.Cashier_closing_paymentsService = new Cashier_closing_paymentsService(Client);
            this.Cash_flow_mapperService = new Cash_flow_mapperService(Client);
            this.Cash_flow_mappingService = new Cash_flow_mappingService(Client);
            this.Cash_flow_mapping_accountsService = new Cash_flow_mapping_accountsService(Client);
            this.Cash_flow_mapping_templateService = new Cash_flow_mapping_templateService(Client);
            this.Cash_flow_mapping_template_detailsService = new Cash_flow_mapping_template_detailsService(Client);
            this.Chart_of_accounts_importerService = new Chart_of_accounts_importerService(Client);
            this.Cheque_print_templateService = new Cheque_print_templateService(Client);
            this.Closed_documentService = new Closed_documentService(Client);
            this.Cost_centerService = new Cost_centerService(Client);
            this.Coupon_codeService = new Coupon_codeService(Client);
            this.C_formService = new C_formService(Client);
            this.C_form_invoice_detailService = new C_form_invoice_detailService(Client);
            this.Discounted_invoiceService = new Discounted_invoiceService(Client);
            this.Exchange_rate_revaluationService = new Exchange_rate_revaluationService(Client);
            this.Exchange_rate_revaluation_accountService = new Exchange_rate_revaluation_accountService(Client);
            this.Finance_bookService = new Finance_bookService(Client);
            this.Fiscal_yearService = new Fiscal_yearService(Client);
            this.Fiscal_year_companyService = new Fiscal_year_companyService(Client);
            this.Gl_entryService = new Gl_entryService(Client);
            this.Gst_accountService = new Gst_accountService(Client);
            this.Invoice_discountingService = new Invoice_discountingService(Client);
            this.Item_tax_templateService = new Item_tax_templateService(Client);
            this.Item_tax_template_detailService = new Item_tax_template_detailService(Client);
            this.Journal_entryService = new Journal_entryService(Client);
            this.Journal_entry_accountService = new Journal_entry_accountService(Client);
            this.Journal_entry_templateService = new Journal_entry_templateService(Client);
            this.Journal_entry_template_accountService = new Journal_entry_template_accountService(Client);
            this.Loyalty_point_entryService = new Loyalty_point_entryService(Client);
            this.Loyalty_point_entry_redemptionService = new Loyalty_point_entry_redemptionService(Client);
            this.Loyalty_programService = new Loyalty_programService(Client);
            this.Loyalty_program_collectionService = new Loyalty_program_collectionService(Client);
            this.Mode_of_paymentService = new Mode_of_paymentService(Client);
            this.Mode_of_payment_accountService = new Mode_of_payment_accountService(Client);
            this.Monthly_distributionService = new Monthly_distributionService(Client);
            this.Monthly_distribution_percentageService = new Monthly_distribution_percentageService(Client);
            this.Opening_invoice_creation_toolService = new Opening_invoice_creation_toolService(Client);
            this.Opening_invoice_creation_tool_itemService = new Opening_invoice_creation_tool_itemService(Client);
            this.Party_accountService = new Party_accountService(Client);
            this.Payment_entryService = new Payment_entryService(Client);
            this.Payment_entry_deductionService = new Payment_entry_deductionService(Client);
            this.Payment_entry_referenceService = new Payment_entry_referenceService(Client);
            this.Payment_gateway_accountService = new Payment_gateway_accountService(Client);
            this.Payment_orderService = new Payment_orderService(Client);
            this.Payment_order_referenceService = new Payment_order_referenceService(Client);
            this.Payment_reconciliationService = new Payment_reconciliationService(Client);
            this.Payment_reconciliation_invoiceService = new Payment_reconciliation_invoiceService(Client);
            this.Payment_reconciliation_paymentService = new Payment_reconciliation_paymentService(Client);
            this.Payment_requestService = new Payment_requestService(Client);
            this.Payment_scheduleService = new Payment_scheduleService(Client);
            this.Payment_termService = new Payment_termService(Client);
            this.Payment_terms_templateService = new Payment_terms_templateService(Client);
            this.Payment_terms_template_detailService = new Payment_terms_template_detailService(Client);
            this.Period_closing_voucherService = new Period_closing_voucherService(Client);
            this.Pos_customer_groupService = new Pos_customer_groupService(Client);
            this.Pos_fieldService = new Pos_fieldService(Client);
            this.Pos_item_groupService = new Pos_item_groupService(Client);
            this.Pos_profileService = new Pos_profileService(Client);
            this.Pos_profile_userService = new Pos_profile_userService(Client);
            this.Pos_settingsService = new Pos_settingsService(Client);
            this.Pricing_ruleService = new Pricing_ruleService(Client);
            this.Pricing_rule_brandService = new Pricing_rule_brandService(Client);
            this.Pricing_rule_detailService = new Pricing_rule_detailService(Client);
            this.Pricing_rule_item_codeService = new Pricing_rule_item_codeService(Client);
            this.Pricing_rule_item_groupService = new Pricing_rule_item_groupService(Client);
            this.Process_deferred_accountingService = new Process_deferred_accountingService(Client);
            this.Promotional_schemeService = new Promotional_schemeService(Client);
            this.Promotional_scheme_price_discountService = new Promotional_scheme_price_discountService(Client);
            this.Promotional_scheme_product_discountService = new Promotional_scheme_product_discountService(Client);
            this.Purchase_invoiceService = new Purchase_invoiceService(Client);
            this.Purchase_invoice_advanceService = new Purchase_invoice_advanceService(Client);
            this.Purchase_invoice_itemService = new Purchase_invoice_itemService(Client);
            this.Purchase_taxes_and_chargesService = new Purchase_taxes_and_chargesService(Client);
            this.Purchase_taxes_and_charges_templateService = new Purchase_taxes_and_charges_templateService(Client);
            this.Salary_component_accountService = new Salary_component_accountService(Client);
            this.Sales_invoiceService = new Sales_invoiceService(Client);
            this.Sales_invoice_advanceService = new Sales_invoice_advanceService(Client);
            this.Sales_invoice_itemService = new Sales_invoice_itemService(Client);
            this.Sales_invoice_paymentService = new Sales_invoice_paymentService(Client);
            this.Sales_invoice_timesheetService = new Sales_invoice_timesheetService(Client);
            this.Sales_taxes_and_chargesService = new Sales_taxes_and_chargesService(Client);
            this.Sales_taxes_and_charges_templateService = new Sales_taxes_and_charges_templateService(Client);
            this.ShareholderService = new ShareholderService(Client);
            this.Share_balanceService = new Share_balanceService(Client);
            this.Share_transferService = new Share_transferService(Client);
            this.Share_typeService = new Share_typeService(Client);
            this.Shipping_ruleService = new Shipping_ruleService(Client);
            this.Shipping_rule_conditionService = new Shipping_rule_conditionService(Client);
            this.Shipping_rule_countryService = new Shipping_rule_countryService(Client);
            this.SubscriptionService = new SubscriptionService(Client);
            this.Subscription_invoiceService = new Subscription_invoiceService(Client);
            this.Subscription_planService = new Subscription_planService(Client);
            this.Subscription_plan_detailService = new Subscription_plan_detailService(Client);
            this.Subscription_settingsService = new Subscription_settingsService(Client);
            this.Tax_categoryService = new Tax_categoryService(Client);
            this.Tax_ruleService = new Tax_ruleService(Client);
            this.Tax_withholding_accountService = new Tax_withholding_accountService(Client);
            this.Tax_withholding_categoryService = new Tax_withholding_categoryService(Client);
            this.Tax_withholding_rateService = new Tax_withholding_rateService(Client);
            this.Agriculture_analysis_criteriaService = new Agriculture_analysis_criteriaService(Client);
            this.Agriculture_taskService = new Agriculture_taskService(Client);
            this.CropService = new CropService(Client);
            this.Crop_cycleService = new Crop_cycleService(Client);
            this.Detected_diseaseService = new Detected_diseaseService(Client);
            this.DiseaseService = new DiseaseService(Client);
            this.FertilizerService = new FertilizerService(Client);
            this.Fertilizer_contentService = new Fertilizer_contentService(Client);
            this.Linked_locationService = new Linked_locationService(Client);
            this.Linked_plant_analysisService = new Linked_plant_analysisService(Client);
            this.Linked_soil_analysisService = new Linked_soil_analysisService(Client);
            this.Linked_soil_textureService = new Linked_soil_textureService(Client);
            this.Plant_analysisService = new Plant_analysisService(Client);
            this.Plant_analysis_criteriaService = new Plant_analysis_criteriaService(Client);
            this.Soil_analysisService = new Soil_analysisService(Client);
            this.Soil_analysis_criteriaService = new Soil_analysis_criteriaService(Client);
            this.Soil_textureService = new Soil_textureService(Client);
            this.Soil_texture_criteriaService = new Soil_texture_criteriaService(Client);
            this.Water_analysisService = new Water_analysisService(Client);
            this.Water_analysis_criteriaService = new Water_analysis_criteriaService(Client);
            this.WeatherService = new WeatherService(Client);
            this.Weather_parameterService = new Weather_parameterService(Client);
            this.AssetService = new AssetService(Client);
            this.Asset_categoryService = new Asset_categoryService(Client);
            this.Asset_category_accountService = new Asset_category_accountService(Client);
            this.Asset_finance_bookService = new Asset_finance_bookService(Client);
            this.Asset_maintenanceService = new Asset_maintenanceService(Client);
            this.Asset_maintenance_logService = new Asset_maintenance_logService(Client);
            this.Asset_maintenance_taskService = new Asset_maintenance_taskService(Client);
            this.Asset_maintenance_teamService = new Asset_maintenance_teamService(Client);
            this.Asset_movementService = new Asset_movementService(Client);
            this.Asset_movement_itemService = new Asset_movement_itemService(Client);
            this.Asset_repairService = new Asset_repairService(Client);
            this.Asset_value_adjustmentService = new Asset_value_adjustmentService(Client);
            this.Depreciation_scheduleService = new Depreciation_scheduleService(Client);
            this.Linked_locationService = new Linked_locationService(Client);
            this.LocationService = new LocationService(Client);
            this.Maintenance_team_memberService = new Maintenance_team_memberService(Client);
            this.Buying_settingsService = new Buying_settingsService(Client);
            this.Purchase_orderService = new Purchase_orderService(Client);
            this.Purchase_order_itemService = new Purchase_order_itemService(Client);
            this.Purchase_order_item_suppliedService = new Purchase_order_item_suppliedService(Client);
            this.Purchase_receipt_item_suppliedService = new Purchase_receipt_item_suppliedService(Client);
            this.Request_for_quotationService = new Request_for_quotationService(Client);
            this.Request_for_quotation_itemService = new Request_for_quotation_itemService(Client);
            this.Request_for_quotation_supplierService = new Request_for_quotation_supplierService(Client);
            this.SupplierService = new SupplierService(Client);
            this.Supplier_quotationService = new Supplier_quotationService(Client);
            this.Supplier_quotation_itemService = new Supplier_quotation_itemService(Client);
            this.Supplier_scorecardService = new Supplier_scorecardService(Client);
            this.Supplier_scorecard_criteriaService = new Supplier_scorecard_criteriaService(Client);
            this.Supplier_scorecard_periodService = new Supplier_scorecard_periodService(Client);
            this.Supplier_scorecard_scoring_criteriaService = new Supplier_scorecard_scoring_criteriaService(Client);
            this.Supplier_scorecard_scoring_standingService = new Supplier_scorecard_scoring_standingService(Client);
            this.Supplier_scorecard_scoring_variableService = new Supplier_scorecard_scoring_variableService(Client);
            this.Supplier_scorecard_standingService = new Supplier_scorecard_standingService(Client);
            this.Supplier_scorecard_variableService = new Supplier_scorecard_variableService(Client);
            this.Call_logService = new Call_logService(Client);
            this.Communication_mediumService = new Communication_mediumService(Client);
            this.Communication_medium_timeslotService = new Communication_medium_timeslotService(Client);
            this.AppointmentService = new AppointmentService(Client);
            this.Appointment_booking_settingsService = new Appointment_booking_settingsService(Client);
            this.Appointment_booking_slotsService = new Appointment_booking_slotsService(Client);
            this.Availability_of_slotsService = new Availability_of_slotsService(Client);
            this.Campaign_email_scheduleService = new Campaign_email_scheduleService(Client);
            this.ContractService = new ContractService(Client);
            this.Contract_fulfilment_checklistService = new Contract_fulfilment_checklistService(Client);
            this.Contract_templateService = new Contract_templateService(Client);
            this.Contract_template_fulfilment_termsService = new Contract_template_fulfilment_termsService(Client);
            this.Email_campaignService = new Email_campaignService(Client);
            this.LeadService = new LeadService(Client);
            this.Linkedin_settingsService = new Linkedin_settingsService(Client);
            this.Lost_reason_detailService = new Lost_reason_detailService(Client);
            this.Market_segmentService = new Market_segmentService(Client);
            this.OpportunityService = new OpportunityService(Client);
            this.Opportunity_itemService = new Opportunity_itemService(Client);
            this.Opportunity_lost_reasonService = new Opportunity_lost_reasonService(Client);
            this.Opportunity_typeService = new Opportunity_typeService(Client);
            this.Sales_stageService = new Sales_stageService(Client);
            this.Social_media_postService = new Social_media_postService(Client);
            this.Twitter_settingsService = new Twitter_settingsService(Client);
            this.Academic_termService = new Academic_termService(Client);
            this.Academic_yearService = new Academic_yearService(Client);
            this.ArticleService = new ArticleService(Client);
            this.Assessment_criteriaService = new Assessment_criteriaService(Client);
            this.Assessment_criteria_groupService = new Assessment_criteria_groupService(Client);
            this.Assessment_groupService = new Assessment_groupService(Client);
            this.Assessment_planService = new Assessment_planService(Client);
            this.Assessment_plan_criteriaService = new Assessment_plan_criteriaService(Client);
            this.Assessment_resultService = new Assessment_resultService(Client);
            this.Assessment_result_detailService = new Assessment_result_detailService(Client);
            this.Assessment_result_toolService = new Assessment_result_toolService(Client);
            this.Content_activityService = new Content_activityService(Client);
            this.Content_questionService = new Content_questionService(Client);
            this.CourseService = new CourseService(Client);
            this.Course_activityService = new Course_activityService(Client);
            this.Course_assessment_criteriaService = new Course_assessment_criteriaService(Client);
            this.Course_contentService = new Course_contentService(Client);
            this.Course_enrollmentService = new Course_enrollmentService(Client);
            this.Course_scheduleService = new Course_scheduleService(Client);
            this.Course_scheduling_toolService = new Course_scheduling_toolService(Client);
            this.Course_topicService = new Course_topicService(Client);
            this.Education_settingsService = new Education_settingsService(Client);
            this.FeesService = new FeesService(Client);
            this.Fee_categoryService = new Fee_categoryService(Client);
            this.Fee_componentService = new Fee_componentService(Client);
            this.Fee_scheduleService = new Fee_scheduleService(Client);
            this.Fee_schedule_programService = new Fee_schedule_programService(Client);
            this.Fee_schedule_student_groupService = new Fee_schedule_student_groupService(Client);
            this.Fee_structureService = new Fee_structureService(Client);
            this.Grading_scaleService = new Grading_scaleService(Client);
            this.Grading_scale_intervalService = new Grading_scale_intervalService(Client);
            this.GuardianService = new GuardianService(Client);
            this.Guardian_interestService = new Guardian_interestService(Client);
            this.Guardian_studentService = new Guardian_studentService(Client);
            this.InstructorService = new InstructorService(Client);
            this.Instructor_logService = new Instructor_logService(Client);
            this.OptionsService = new OptionsService(Client);
            this.ProgramService = new ProgramService(Client);
            this.Program_courseService = new Program_courseService(Client);
            this.Program_enrollmentService = new Program_enrollmentService(Client);
            this.Program_enrollment_courseService = new Program_enrollment_courseService(Client);
            this.Program_enrollment_feeService = new Program_enrollment_feeService(Client);
            this.Program_enrollment_toolService = new Program_enrollment_toolService(Client);
            this.Program_enrollment_tool_studentService = new Program_enrollment_tool_studentService(Client);
            this.Program_feeService = new Program_feeService(Client);
            this.QuestionService = new QuestionService(Client);
            this.QuizService = new QuizService(Client);
            this.Quiz_activityService = new Quiz_activityService(Client);
            this.Quiz_questionService = new Quiz_questionService(Client);
            this.Quiz_resultService = new Quiz_resultService(Client);
            this.RoomService = new RoomService(Client);
            this.School_houseService = new School_houseService(Client);
            this.StudentService = new StudentService(Client);
            this.Student_admissionService = new Student_admissionService(Client);
            this.Student_admission_programService = new Student_admission_programService(Client);
            this.Student_applicantService = new Student_applicantService(Client);
            this.Student_attendanceService = new Student_attendanceService(Client);
            this.Student_attendance_toolService = new Student_attendance_toolService(Client);
            this.Student_batch_nameService = new Student_batch_nameService(Client);
            this.Student_categoryService = new Student_categoryService(Client);
            this.Student_groupService = new Student_groupService(Client);
            this.Student_group_creation_toolService = new Student_group_creation_toolService(Client);
            this.Student_group_creation_tool_courseService = new Student_group_creation_tool_courseService(Client);
            this.Student_group_instructorService = new Student_group_instructorService(Client);
            this.Student_group_studentService = new Student_group_studentService(Client);
            this.Student_guardianService = new Student_guardianService(Client);
            this.Student_languageService = new Student_languageService(Client);
            this.Student_leave_applicationService = new Student_leave_applicationService(Client);
            this.Student_logService = new Student_logService(Client);
            this.Student_report_generation_toolService = new Student_report_generation_toolService(Client);
            this.Student_siblingService = new Student_siblingService(Client);
            this.Student_siblingsService = new Student_siblingsService(Client);
            this.TopicService = new TopicService(Client);
            this.Topic_contentService = new Topic_contentService(Client);
            this.Amazon_mws_settingsService = new Amazon_mws_settingsService(Client);
            this.Exotel_settingsService = new Exotel_settingsService(Client);
            this.Gocardless_mandateService = new Gocardless_mandateService(Client);
            this.Gocardless_settingsService = new Gocardless_settingsService(Client);
            this.Plaid_settingsService = new Plaid_settingsService(Client);
            this.Quickbooks_migratorService = new Quickbooks_migratorService(Client);
            this.Shopify_logService = new Shopify_logService(Client);
            this.Shopify_settingsService = new Shopify_settingsService(Client);
            this.Shopify_customerService = new Shopify_customerService(Client);
            this.Shopify_itemService = new Shopify_itemService(Client);
            this.Shopify_orderService = new Shopify_orderService(Client);
            this.Shopify_tax_accountService = new Shopify_tax_accountService(Client);
            this.Shopify_webhook_detailService = new Shopify_webhook_detailService(Client);
            this.Tally_migrationService = new Tally_migrationService(Client);
            this.Woocommerce_settingsService = new Woocommerce_settingsService(Client);
            this.AntibioticService = new AntibioticService(Client);
            this.Appointment_typeService = new Appointment_typeService(Client);
            this.Body_partService = new Body_partService(Client);
            this.Body_part_linkService = new Body_part_linkService(Client);
            this.Clinical_procedureService = new Clinical_procedureService(Client);
            this.Clinical_procedure_itemService = new Clinical_procedure_itemService(Client);
            this.Clinical_procedure_templateService = new Clinical_procedure_templateService(Client);
            this.Codification_tableService = new Codification_tableService(Client);
            this.ComplaintService = new ComplaintService(Client);
            this.DiagnosisService = new DiagnosisService(Client);
            this.Dosage_formService = new Dosage_formService(Client);
            this.Dosage_strengthService = new Dosage_strengthService(Client);
            this.Drug_prescriptionService = new Drug_prescriptionService(Client);
            this.ExerciseService = new ExerciseService(Client);
            this.Exercise_difficulty_levelService = new Exercise_difficulty_levelService(Client);
            this.Exercise_typeService = new Exercise_typeService(Client);
            this.Exercise_type_stepService = new Exercise_type_stepService(Client);
            this.Fee_validityService = new Fee_validityService(Client);
            this.Fee_validity_referenceService = new Fee_validity_referenceService(Client);
            this.Healthcare_practitionerService = new Healthcare_practitionerService(Client);
            this.Healthcare_schedule_time_slotService = new Healthcare_schedule_time_slotService(Client);
            this.Healthcare_service_unitService = new Healthcare_service_unitService(Client);
            this.Healthcare_service_unit_typeService = new Healthcare_service_unit_typeService(Client);
            this.Healthcare_settingsService = new Healthcare_settingsService(Client);
            this.Inpatient_occupancyService = new Inpatient_occupancyService(Client);
            this.Inpatient_recordService = new Inpatient_recordService(Client);
            this.Lab_prescriptionService = new Lab_prescriptionService(Client);
            this.Lab_testService = new Lab_testService(Client);
            this.Lab_test_groupsService = new Lab_test_groupsService(Client);
            this.Lab_test_sampleService = new Lab_test_sampleService(Client);
            this.Lab_test_templateService = new Lab_test_templateService(Client);
            this.Lab_test_uomService = new Lab_test_uomService(Client);
            this.Medical_codeService = new Medical_codeService(Client);
            this.Medical_code_standardService = new Medical_code_standardService(Client);
            this.Medical_departmentService = new Medical_departmentService(Client);
            this.Normal_test_itemsService = new Normal_test_itemsService(Client);
            this.Normal_test_templateService = new Normal_test_templateService(Client);
            this.PatientService = new PatientService(Client);
            this.Patient_appointmentService = new Patient_appointmentService(Client);
            this.Patient_assessmentService = new Patient_assessmentService(Client);
            this.Patient_assessment_detailService = new Patient_assessment_detailService(Client);
            this.Patient_assessment_parameterService = new Patient_assessment_parameterService(Client);
            this.Patient_assessment_sheetService = new Patient_assessment_sheetService(Client);
            this.Patient_assessment_templateService = new Patient_assessment_templateService(Client);
            this.Patient_encounterService = new Patient_encounterService(Client);
            this.Patient_encounter_diagnosisService = new Patient_encounter_diagnosisService(Client);
            this.Patient_encounter_symptomService = new Patient_encounter_symptomService(Client);
            this.Patient_medical_recordService = new Patient_medical_recordService(Client);
            this.Patient_relationService = new Patient_relationService(Client);
            this.Practitioner_scheduleService = new Practitioner_scheduleService(Client);
            this.Practitioner_service_unit_scheduleService = new Practitioner_service_unit_scheduleService(Client);
            this.Prescription_dosageService = new Prescription_dosageService(Client);
            this.Prescription_durationService = new Prescription_durationService(Client);
            this.Procedure_prescriptionService = new Procedure_prescriptionService(Client);
            this.Sample_collectionService = new Sample_collectionService(Client);
            this.SensitivityService = new SensitivityService(Client);
            this.Sensitivity_test_itemsService = new Sensitivity_test_itemsService(Client);
            this.Special_test_itemsService = new Special_test_itemsService(Client);
            this.Special_test_templateService = new Special_test_templateService(Client);
            this.Therapy_planService = new Therapy_planService(Client);
            this.Therapy_plan_detailService = new Therapy_plan_detailService(Client);
            this.Therapy_sessionService = new Therapy_sessionService(Client);
            this.Therapy_typeService = new Therapy_typeService(Client);
            this.Vital_signsService = new Vital_signsService(Client);
            this.Hotel_roomService = new Hotel_roomService(Client);
            this.Hotel_room_amenityService = new Hotel_room_amenityService(Client);
            this.Hotel_room_packageService = new Hotel_room_packageService(Client);
            this.Hotel_room_pricingService = new Hotel_room_pricingService(Client);
            this.Hotel_room_pricing_itemService = new Hotel_room_pricing_itemService(Client);
            this.Hotel_room_pricing_packageService = new Hotel_room_pricing_packageService(Client);
            this.Hotel_room_reservationService = new Hotel_room_reservationService(Client);
            this.Hotel_room_reservation_itemService = new Hotel_room_reservation_itemService(Client);
            this.Hotel_room_typeService = new Hotel_room_typeService(Client);
            this.Hotel_settingsService = new Hotel_settingsService(Client);
            this.Additional_salaryService = new Additional_salaryService(Client);
            this.Appointment_letterService = new Appointment_letterService(Client);
            this.Appointment_letter_contentService = new Appointment_letter_contentService(Client);
            this.Appointment_letter_templateService = new Appointment_letter_templateService(Client);
            this.AppraisalService = new AppraisalService(Client);
            this.Appraisal_goalService = new Appraisal_goalService(Client);
            this.Appraisal_templateService = new Appraisal_templateService(Client);
            this.Appraisal_template_goalService = new Appraisal_template_goalService(Client);
            this.AttendanceService = new AttendanceService(Client);
            this.Attendance_requestService = new Attendance_requestService(Client);
            this.BranchService = new BranchService(Client);
            this.Compensatory_leave_requestService = new Compensatory_leave_requestService(Client);
            this.Daily_work_summaryService = new Daily_work_summaryService(Client);
            this.Daily_work_summary_groupService = new Daily_work_summary_groupService(Client);
            this.Daily_work_summary_group_userService = new Daily_work_summary_group_userService(Client);
            this.DepartmentService = new DepartmentService(Client);
            this.Department_approverService = new Department_approverService(Client);
            this.DesignationService = new DesignationService(Client);
            this.Designation_skillService = new Designation_skillService(Client);
            this.DriverService = new DriverService(Client);
            this.Driving_license_categoryService = new Driving_license_categoryService(Client);
            this.EmployeeService = new EmployeeService(Client);
            this.Employee_advanceService = new Employee_advanceService(Client);
            this.Employee_attendance_toolService = new Employee_attendance_toolService(Client);
            this.Employee_benefit_applicationService = new Employee_benefit_applicationService(Client);
            this.Employee_benefit_application_detailService = new Employee_benefit_application_detailService(Client);
            this.Employee_benefit_claimService = new Employee_benefit_claimService(Client);
            this.Employee_boarding_activityService = new Employee_boarding_activityService(Client);
            this.Employee_checkinService = new Employee_checkinService(Client);
            this.Employee_educationService = new Employee_educationService(Client);
            this.Employee_external_work_historyService = new Employee_external_work_historyService(Client);
            this.Employee_gradeService = new Employee_gradeService(Client);
            this.Employee_groupService = new Employee_groupService(Client);
            this.Employee_group_tableService = new Employee_group_tableService(Client);
            this.Employee_health_insuranceService = new Employee_health_insuranceService(Client);
            this.Employee_incentiveService = new Employee_incentiveService(Client);
            this.Employee_internal_work_historyService = new Employee_internal_work_historyService(Client);
            this.Employee_onboardingService = new Employee_onboardingService(Client);
            this.Employee_onboarding_activityService = new Employee_onboarding_activityService(Client);
            this.Employee_onboarding_templateService = new Employee_onboarding_templateService(Client);
            this.Employee_other_incomeService = new Employee_other_incomeService(Client);
            this.Employee_promotionService = new Employee_promotionService(Client);
            this.Employee_property_historyService = new Employee_property_historyService(Client);
            this.Employee_separationService = new Employee_separationService(Client);
            this.Employee_separation_templateService = new Employee_separation_templateService(Client);
            this.Employee_skillService = new Employee_skillService(Client);
            this.Employee_skill_mapService = new Employee_skill_mapService(Client);
            this.Employee_tax_exemption_categoryService = new Employee_tax_exemption_categoryService(Client);
            this.Employee_tax_exemption_declarationService = new Employee_tax_exemption_declarationService(Client);
            this.Employee_tax_exemption_declaration_categoryService = new Employee_tax_exemption_declaration_categoryService(Client);
            this.Employee_tax_exemption_proof_submissionService = new Employee_tax_exemption_proof_submissionService(Client);
            this.Employee_tax_exemption_proof_submission_detailService = new Employee_tax_exemption_proof_submission_detailService(Client);
            this.Employee_tax_exemption_sub_categoryService = new Employee_tax_exemption_sub_categoryService(Client);
            this.Employee_trainingService = new Employee_trainingService(Client);
            this.Employee_transferService = new Employee_transferService(Client);
            this.Employee_transfer_propertyService = new Employee_transfer_propertyService(Client);
            this.Employment_typeService = new Employment_typeService(Client);
            this.Expense_claimService = new Expense_claimService(Client);
            this.Expense_claim_accountService = new Expense_claim_accountService(Client);
            this.Expense_claim_advanceService = new Expense_claim_advanceService(Client);
            this.Expense_claim_detailService = new Expense_claim_detailService(Client);
            this.Expense_claim_typeService = new Expense_claim_typeService(Client);
            this.Expense_taxes_and_chargesService = new Expense_taxes_and_chargesService(Client);
            this.HolidayService = new HolidayService(Client);
            this.Holiday_listService = new Holiday_listService(Client);
            this.Hr_settingsService = new Hr_settingsService(Client);
            this.Identification_document_typeService = new Identification_document_typeService(Client);
            this.Income_tax_slabService = new Income_tax_slabService(Client);
            this.Income_tax_slab_other_chargesService = new Income_tax_slab_other_chargesService(Client);
            this.InterestService = new InterestService(Client);
            this.Job_applicantService = new Job_applicantService(Client);
            this.Job_applicant_sourceService = new Job_applicant_sourceService(Client);
            this.Job_offerService = new Job_offerService(Client);
            this.Job_offer_termService = new Job_offer_termService(Client);
            this.Job_openingService = new Job_openingService(Client);
            this.Leave_allocationService = new Leave_allocationService(Client);
            this.Leave_applicationService = new Leave_applicationService(Client);
            this.Leave_block_listService = new Leave_block_listService(Client);
            this.Leave_block_list_allowService = new Leave_block_list_allowService(Client);
            this.Leave_block_list_dateService = new Leave_block_list_dateService(Client);
            this.Leave_control_panelService = new Leave_control_panelService(Client);
            this.Leave_encashmentService = new Leave_encashmentService(Client);
            this.Leave_ledger_entryService = new Leave_ledger_entryService(Client);
            this.Leave_periodService = new Leave_periodService(Client);
            this.Leave_policyService = new Leave_policyService(Client);
            this.Leave_policy_detailService = new Leave_policy_detailService(Client);
            this.Leave_typeService = new Leave_typeService(Client);
            this.Offer_termService = new Offer_termService(Client);
            this.Payroll_employee_detailService = new Payroll_employee_detailService(Client);
            this.Payroll_entryService = new Payroll_entryService(Client);
            this.Payroll_periodService = new Payroll_periodService(Client);
            this.Payroll_period_dateService = new Payroll_period_dateService(Client);
            this.Purpose_of_travelService = new Purpose_of_travelService(Client);
            this.Retention_bonusService = new Retention_bonusService(Client);
            this.Salary_componentService = new Salary_componentService(Client);
            this.Salary_detailService = new Salary_detailService(Client);
            this.Salary_slipService = new Salary_slipService(Client);
            this.Salary_slip_timesheetService = new Salary_slip_timesheetService(Client);
            this.Salary_structureService = new Salary_structureService(Client);
            this.Salary_structure_assignmentService = new Salary_structure_assignmentService(Client);
            this.Shift_assignmentService = new Shift_assignmentService(Client);
            this.Shift_requestService = new Shift_requestService(Client);
            this.Shift_typeService = new Shift_typeService(Client);
            this.SkillService = new SkillService(Client);
            this.Staffing_planService = new Staffing_planService(Client);
            this.Staffing_plan_detailService = new Staffing_plan_detailService(Client);
            this.Taxable_salary_slabService = new Taxable_salary_slabService(Client);
            this.Training_eventService = new Training_eventService(Client);
            this.Training_event_employeeService = new Training_event_employeeService(Client);
            this.Training_feedbackService = new Training_feedbackService(Client);
            this.Training_programService = new Training_programService(Client);
            this.Training_resultService = new Training_resultService(Client);
            this.Training_result_employeeService = new Training_result_employeeService(Client);
            this.Travel_itineraryService = new Travel_itineraryService(Client);
            this.Travel_requestService = new Travel_requestService(Client);
            this.Travel_request_costingService = new Travel_request_costingService(Client);
            this.Upload_attendanceService = new Upload_attendanceService(Client);
            this.VehicleService = new VehicleService(Client);
            this.Vehicle_logService = new Vehicle_logService(Client);
            this.Vehicle_serviceService = new Vehicle_serviceService(Client);
            this.Hub_tracked_itemService = new Hub_tracked_itemService(Client);
            this.Hub_userService = new Hub_userService(Client);
            this.Hub_usersService = new Hub_usersService(Client);
            this.Marketplace_settingsService = new Marketplace_settingsService(Client);
            this.LoanService = new LoanService(Client);
            this.Loan_applicationService = new Loan_applicationService(Client);
            this.Loan_disbursementService = new Loan_disbursementService(Client);
            this.Loan_interest_accrualService = new Loan_interest_accrualService(Client);
            this.Loan_repaymentService = new Loan_repaymentService(Client);
            this.Loan_repayment_detailService = new Loan_repayment_detailService(Client);
            this.Loan_securityService = new Loan_securityService(Client);
            this.Loan_security_pledgeService = new Loan_security_pledgeService(Client);
            this.Loan_security_priceService = new Loan_security_priceService(Client);
            this.Loan_security_shortfallService = new Loan_security_shortfallService(Client);
            this.Loan_security_typeService = new Loan_security_typeService(Client);
            this.Loan_security_unpledgeService = new Loan_security_unpledgeService(Client);
            this.Loan_typeService = new Loan_typeService(Client);
            this.PledgeService = new PledgeService(Client);
            this.Process_loan_interest_accrualService = new Process_loan_interest_accrualService(Client);
            this.Process_loan_security_shortfallService = new Process_loan_security_shortfallService(Client);
            this.Proposed_pledgeService = new Proposed_pledgeService(Client);
            this.Repayment_scheduleService = new Repayment_scheduleService(Client);
            this.Salary_slip_loanService = new Salary_slip_loanService(Client);
            this.Sanctioned_loan_amountService = new Sanctioned_loan_amountService(Client);
            this.UnpledgeService = new UnpledgeService(Client);
            this.Maintenance_scheduleService = new Maintenance_scheduleService(Client);
            this.Maintenance_schedule_detailService = new Maintenance_schedule_detailService(Client);
            this.Maintenance_schedule_itemService = new Maintenance_schedule_itemService(Client);
            this.Maintenance_visitService = new Maintenance_visitService(Client);
            this.Maintenance_visit_purposeService = new Maintenance_visit_purposeService(Client);
            this.Blanket_orderService = new Blanket_orderService(Client);
            this.Blanket_order_itemService = new Blanket_order_itemService(Client);
            this.BomService = new BomService(Client);
            this.Bom_explosion_itemService = new Bom_explosion_itemService(Client);
            this.Bom_itemService = new Bom_itemService(Client);
            this.Bom_operationService = new Bom_operationService(Client);
            this.Bom_scrap_itemService = new Bom_scrap_itemService(Client);
            this.Bom_update_toolService = new Bom_update_toolService(Client);
            this.Bom_website_itemService = new Bom_website_itemService(Client);
            this.Bom_website_operationService = new Bom_website_operationService(Client);
            this.Downtime_entryService = new Downtime_entryService(Client);
            this.Job_cardService = new Job_cardService(Client);
            this.Job_card_itemService = new Job_card_itemService(Client);
            this.Job_card_time_logService = new Job_card_time_logService(Client);
            this.Manufacturing_settingsService = new Manufacturing_settingsService(Client);
            this.Material_request_plan_itemService = new Material_request_plan_itemService(Client);
            this.OperationService = new OperationService(Client);
            this.Production_planService = new Production_planService(Client);
            this.Production_plan_itemService = new Production_plan_itemService(Client);
            this.Production_plan_material_requestService = new Production_plan_material_requestService(Client);
            this.Production_plan_material_request_warehouseService = new Production_plan_material_request_warehouseService(Client);
            this.Production_plan_sales_orderService = new Production_plan_sales_orderService(Client);
            this.RoutingService = new RoutingService(Client);
            this.WorkstationService = new WorkstationService(Client);
            this.Workstation_working_hourService = new Workstation_working_hourService(Client);
            this.Work_orderService = new Work_orderService(Client);
            this.Work_order_itemService = new Work_order_itemService(Client);
            this.Work_order_operationService = new Work_order_operationService(Client);
            this.Certification_applicationService = new Certification_applicationService(Client);
            this.Certified_consultantService = new Certified_consultantService(Client);
            this.ChapterService = new ChapterService(Client);
            this.Chapter_memberService = new Chapter_memberService(Client);
            this.DonorService = new DonorService(Client);
            this.Donor_typeService = new Donor_typeService(Client);
            this.Grant_applicationService = new Grant_applicationService(Client);
            this.MemberService = new MemberService(Client);
            this.MembershipService = new MembershipService(Client);
            this.Membership_settingsService = new Membership_settingsService(Client);
            this.Membership_typeService = new Membership_typeService(Client);
            this.VolunteerService = new VolunteerService(Client);
            this.Volunteer_skillService = new Volunteer_skillService(Client);
            this.Volunteer_typeService = new Volunteer_typeService(Client);
            this.HomepageService = new HomepageService(Client);
            this.Homepage_featured_productService = new Homepage_featured_productService(Client);
            this.Homepage_sectionService = new Homepage_sectionService(Client);
            this.Homepage_section_cardService = new Homepage_section_cardService(Client);
            this.Products_settingsService = new Products_settingsService(Client);
            this.Website_attributeService = new Website_attributeService(Client);
            this.Website_filter_fieldService = new Website_filter_fieldService(Client);
            this.Activity_costService = new Activity_costService(Client);
            this.Activity_typeService = new Activity_typeService(Client);
            this.Dependent_taskService = new Dependent_taskService(Client);
            this.ProjectService = new ProjectService(Client);
            this.Projects_settingsService = new Projects_settingsService(Client);
            this.Project_templateService = new Project_templateService(Client);
            this.Project_template_taskService = new Project_template_taskService(Client);
            this.Project_typeService = new Project_typeService(Client);
            this.Project_updateService = new Project_updateService(Client);
            this.Project_userService = new Project_userService(Client);
            this.TaskService = new TaskService(Client);
            this.Task_depends_onService = new Task_depends_onService(Client);
            this.Task_typeService = new Task_typeService(Client);
            this.TimesheetService = new TimesheetService(Client);
            this.Timesheet_detailService = new Timesheet_detailService(Client);
            this.Quality_actionService = new Quality_actionService(Client);
            this.Quality_action_resolutionService = new Quality_action_resolutionService(Client);
            this.Quality_feedbackService = new Quality_feedbackService(Client);
            this.Quality_feedback_parameterService = new Quality_feedback_parameterService(Client);
            this.Quality_feedback_templateService = new Quality_feedback_templateService(Client);
            this.Quality_feedback_template_parameterService = new Quality_feedback_template_parameterService(Client);
            this.Quality_goalService = new Quality_goalService(Client);
            this.Quality_goal_objectiveService = new Quality_goal_objectiveService(Client);
            this.Quality_meetingService = new Quality_meetingService(Client);
            this.Quality_meeting_agendaService = new Quality_meeting_agendaService(Client);
            this.Quality_meeting_minutesService = new Quality_meeting_minutesService(Client);
            this.Quality_procedureService = new Quality_procedureService(Client);
            this.Quality_procedure_processService = new Quality_procedure_processService(Client);
            this.Quality_reviewService = new Quality_reviewService(Client);
            this.Quality_review_objectiveService = new Quality_review_objectiveService(Client);
            this.Datev_settingsService = new Datev_settingsService(Client);
            this.Gstr_3b_reportService = new Gstr_3b_reportService(Client);
            this.Gst_hsn_codeService = new Gst_hsn_codeService(Client);
            this.Gst_settingsService = new Gst_settingsService(Client);
            this.Import_supplier_invoiceService = new Import_supplier_invoiceService(Client);
            this.Lower_deduction_certificateService = new Lower_deduction_certificateService(Client);
            this.RestaurantService = new RestaurantService(Client);
            this.Restaurant_menuService = new Restaurant_menuService(Client);
            this.Restaurant_menu_itemService = new Restaurant_menu_itemService(Client);
            this.Restaurant_order_entryService = new Restaurant_order_entryService(Client);
            this.Restaurant_order_entry_itemService = new Restaurant_order_entry_itemService(Client);
            this.Restaurant_reservationService = new Restaurant_reservationService(Client);
            this.Restaurant_tableService = new Restaurant_tableService(Client);
            this.CampaignService = new CampaignService(Client);
            this.CustomerService = new CustomerService(Client);
            this.Customer_credit_limitService = new Customer_credit_limitService(Client);
            this.Industry_typeService = new Industry_typeService(Client);
            this.Installation_noteService = new Installation_noteService(Client);
            this.Installation_note_itemService = new Installation_note_itemService(Client);
            this.Lead_sourceService = new Lead_sourceService(Client);
            this.Pos_closing_voucherService = new Pos_closing_voucherService(Client);
            this.Pos_closing_voucher_detailsService = new Pos_closing_voucher_detailsService(Client);
            this.Pos_closing_voucher_invoicesService = new Pos_closing_voucher_invoicesService(Client);
            this.Pos_closing_voucher_taxesService = new Pos_closing_voucher_taxesService(Client);
            this.Product_bundleService = new Product_bundleService(Client);
            this.Product_bundle_itemService = new Product_bundle_itemService(Client);
            this.QuotationService = new QuotationService(Client);
            this.Quotation_itemService = new Quotation_itemService(Client);
            this.Sales_orderService = new Sales_orderService(Client);
            this.Sales_order_itemService = new Sales_order_itemService(Client);
            this.Sales_partner_typeService = new Sales_partner_typeService(Client);
            this.Sales_teamService = new Sales_teamService(Client);
            this.Selling_settingsService = new Selling_settingsService(Client);
            this.Sms_centerService = new Sms_centerService(Client);
            this.Authorization_controlService = new Authorization_controlService(Client);
            this.Authorization_ruleService = new Authorization_ruleService(Client);
            this.BrandService = new BrandService(Client);
            this.CompanyService = new CompanyService(Client);
            this.Currency_exchangeService = new Currency_exchangeService(Client);
            this.Customer_groupService = new Customer_groupService(Client);
            this.Email_digestService = new Email_digestService(Client);
            this.Global_defaultsService = new Global_defaultsService(Client);
            this.Item_groupService = new Item_groupService(Client);
            this.Naming_seriesService = new Naming_seriesService(Client);
            this.Party_typeService = new Party_typeService(Client);
            this.Print_headingService = new Print_headingService(Client);
            this.Quotation_lost_reasonService = new Quotation_lost_reasonService(Client);
            this.Sales_partnerService = new Sales_partnerService(Client);
            this.Sales_personService = new Sales_personService(Client);
            this.Supplier_groupService = new Supplier_groupService(Client);
            this.Target_detailService = new Target_detailService(Client);
            this.Terms_and_conditionsService = new Terms_and_conditionsService(Client);
            this.TerritoryService = new TerritoryService(Client);
            this.UomService = new UomService(Client);
            this.Uom_conversion_factorService = new Uom_conversion_factorService(Client);
            this.Website_item_groupService = new Website_item_groupService(Client);
            this.Shopping_cart_settingsService = new Shopping_cart_settingsService(Client);
            this.BatchService = new BatchService(Client);
            this.BinService = new BinService(Client);
            this.Customs_tariff_numberService = new Customs_tariff_numberService(Client);
            this.Delivery_noteService = new Delivery_noteService(Client);
            this.Delivery_note_itemService = new Delivery_note_itemService(Client);
            this.Delivery_settingsService = new Delivery_settingsService(Client);
            this.Delivery_stopService = new Delivery_stopService(Client);
            this.Delivery_tripService = new Delivery_tripService(Client);
            this.ItemService = new ItemService(Client);
            this.Item_alternativeService = new Item_alternativeService(Client);
            this.Item_attributeService = new Item_attributeService(Client);
            this.Item_attribute_valueService = new Item_attribute_valueService(Client);
            this.Item_barcodeService = new Item_barcodeService(Client);
            this.Item_customer_detailService = new Item_customer_detailService(Client);
            this.Item_defaultService = new Item_defaultService(Client);
            this.Item_manufacturerService = new Item_manufacturerService(Client);
            this.Item_priceService = new Item_priceService(Client);
            this.Item_quality_inspection_parameterService = new Item_quality_inspection_parameterService(Client);
            this.Item_reorderService = new Item_reorderService(Client);
            this.Item_supplierService = new Item_supplierService(Client);
            this.Item_taxService = new Item_taxService(Client);
            this.Item_variantService = new Item_variantService(Client);
            this.Item_variant_attributeService = new Item_variant_attributeService(Client);
            this.Item_variant_settingsService = new Item_variant_settingsService(Client);
            this.Item_website_specificationService = new Item_website_specificationService(Client);
            this.Landed_cost_itemService = new Landed_cost_itemService(Client);
            this.Landed_cost_purchase_receiptService = new Landed_cost_purchase_receiptService(Client);
            this.Landed_cost_taxes_and_chargesService = new Landed_cost_taxes_and_chargesService(Client);
            this.Landed_cost_voucherService = new Landed_cost_voucherService(Client);
            this.ManufacturerService = new ManufacturerService(Client);
            this.Material_requestService = new Material_requestService(Client);
            this.Material_request_itemService = new Material_request_itemService(Client);
            this.Packed_itemService = new Packed_itemService(Client);
            this.Packing_slipService = new Packing_slipService(Client);
            this.Packing_slip_itemService = new Packing_slip_itemService(Client);
            this.Pick_listService = new Pick_listService(Client);
            this.Pick_list_itemService = new Pick_list_itemService(Client);
            this.Price_listService = new Price_listService(Client);
            this.Price_list_countryService = new Price_list_countryService(Client);
            this.Purchase_receiptService = new Purchase_receiptService(Client);
            this.Purchase_receipt_itemService = new Purchase_receipt_itemService(Client);
            this.Quality_inspectionService = new Quality_inspectionService(Client);
            this.Quality_inspection_readingService = new Quality_inspection_readingService(Client);
            this.Quality_inspection_templateService = new Quality_inspection_templateService(Client);
            this.Quick_stock_balanceService = new Quick_stock_balanceService(Client);
            this.Serial_noService = new Serial_noService(Client);
            this.Stock_entryService = new Stock_entryService(Client);
            this.Stock_entry_detailService = new Stock_entry_detailService(Client);
            this.Stock_entry_typeService = new Stock_entry_typeService(Client);
            this.Stock_ledger_entryService = new Stock_ledger_entryService(Client);
            this.Stock_reconciliationService = new Stock_reconciliationService(Client);
            this.Stock_reconciliation_itemService = new Stock_reconciliation_itemService(Client);
            this.Stock_settingsService = new Stock_settingsService(Client);
            this.Uom_categoryService = new Uom_categoryService(Client);
            this.Uom_conversion_detailService = new Uom_conversion_detailService(Client);
            this.Variant_fieldService = new Variant_fieldService(Client);
            this.WarehouseService = new WarehouseService(Client);
            this.Warehouse_typeService = new Warehouse_typeService(Client);
            this.IssueService = new IssueService(Client);
            this.Issue_priorityService = new Issue_priorityService(Client);
            this.Issue_typeService = new Issue_typeService(Client);
            this.Service_dayService = new Service_dayService(Client);
            this.Service_levelService = new Service_levelService(Client);
            this.Service_level_agreementService = new Service_level_agreementService(Client);
            this.Service_level_priorityService = new Service_level_priorityService(Client);
            this.Support_search_sourceService = new Support_search_sourceService(Client);
            this.Support_settingsService = new Support_settingsService(Client);
            this.Warranty_claimService = new Warranty_claimService(Client);
            this.Rename_toolService = new Rename_toolService(Client);
            this.Sms_logService = new Sms_logService(Client);
        }
    }
}