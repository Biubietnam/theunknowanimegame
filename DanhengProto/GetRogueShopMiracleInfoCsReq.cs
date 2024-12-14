using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007D1 RID: 2001
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueShopMiracleInfoCsReq : IMessage<GetRogueShopMiracleInfoCsReq>, IMessage, IEquatable<GetRogueShopMiracleInfoCsReq>, IDeepCloneable<GetRogueShopMiracleInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x0600593D RID: 22845 RVA: 0x000EE305 File Offset: 0x000EC505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueShopMiracleInfoCsReq> Parser
		{
			get
			{
				return GetRogueShopMiracleInfoCsReq._parser;
			}
		}

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x0600593E RID: 22846 RVA: 0x000EE30C File Offset: 0x000EC50C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueShopMiracleInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x0600593F RID: 22847 RVA: 0x000EE31E File Offset: 0x000EC51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueShopMiracleInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x000EE325 File Offset: 0x000EC525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopMiracleInfoCsReq()
		{
		}

		// Token: 0x06005941 RID: 22849 RVA: 0x000EE32D File Offset: 0x000EC52D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopMiracleInfoCsReq(GetRogueShopMiracleInfoCsReq other) : this()
		{
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this.pUNKLORDOPERATIONREFRESH_ = other.pUNKLORDOPERATIONREFRESH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x000EE35E File Offset: 0x000EC55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopMiracleInfoCsReq Clone()
		{
			return new GetRogueShopMiracleInfoCsReq(this);
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06005943 RID: 22851 RVA: 0x000EE366 File Offset: 0x000EC566
		// (set) Token: 0x06005944 RID: 22852 RVA: 0x000EE36E File Offset: 0x000EC56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x06005945 RID: 22853 RVA: 0x000EE377 File Offset: 0x000EC577
		// (set) Token: 0x06005946 RID: 22854 RVA: 0x000EE37F File Offset: 0x000EC57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PUNKLORDOPERATIONREFRESH
		{
			get
			{
				return this.pUNKLORDOPERATIONREFRESH_;
			}
			set
			{
				this.pUNKLORDOPERATIONREFRESH_ = value;
			}
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x000EE388 File Offset: 0x000EC588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueShopMiracleInfoCsReq);
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x000EE396 File Offset: 0x000EC596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueShopMiracleInfoCsReq other)
		{
			return other != null && (other == this || (this.InteractedPropEntityId == other.InteractedPropEntityId && this.PUNKLORDOPERATIONREFRESH == other.PUNKLORDOPERATIONREFRESH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x000EE3D4 File Offset: 0x000EC5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this.PUNKLORDOPERATIONREFRESH)
			{
				num ^= this.PUNKLORDOPERATIONREFRESH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x000EE42C File Offset: 0x000EC62C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600594B RID: 22859 RVA: 0x000EE434 File Offset: 0x000EC634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600594C RID: 22860 RVA: 0x000EE440 File Offset: 0x000EC640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PUNKLORDOPERATIONREFRESH)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.PUNKLORDOPERATIONREFRESH);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600594D RID: 22861 RVA: 0x000EE49C File Offset: 0x000EC69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this.PUNKLORDOPERATIONREFRESH)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600594E RID: 22862 RVA: 0x000EE4E8 File Offset: 0x000EC6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueShopMiracleInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			if (other.PUNKLORDOPERATIONREFRESH)
			{
				this.PUNKLORDOPERATIONREFRESH = other.PUNKLORDOPERATIONREFRESH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x000EE538 File Offset: 0x000EC738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x000EE544 File Offset: 0x000EC744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractedPropEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.PUNKLORDOPERATIONREFRESH = input.ReadBool();
				}
			}
		}

		// Token: 0x040022B1 RID: 8881
		private static readonly MessageParser<GetRogueShopMiracleInfoCsReq> _parser = new MessageParser<GetRogueShopMiracleInfoCsReq>(() => new GetRogueShopMiracleInfoCsReq());

		// Token: 0x040022B2 RID: 8882
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022B3 RID: 8883
		public const int InteractedPropEntityIdFieldNumber = 12;

		// Token: 0x040022B4 RID: 8884
		private uint interactedPropEntityId_;

		// Token: 0x040022B5 RID: 8885
		public const int PUNKLORDOPERATIONREFRESHFieldNumber = 7;

		// Token: 0x040022B6 RID: 8886
		private bool pUNKLORDOPERATIONREFRESH_;
	}
}
