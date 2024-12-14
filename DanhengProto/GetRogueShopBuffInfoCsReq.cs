using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007CD RID: 1997
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueShopBuffInfoCsReq : IMessage<GetRogueShopBuffInfoCsReq>, IMessage, IEquatable<GetRogueShopBuffInfoCsReq>, IDeepCloneable<GetRogueShopBuffInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x0600590B RID: 22795 RVA: 0x000EDA85 File Offset: 0x000EBC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueShopBuffInfoCsReq> Parser
		{
			get
			{
				return GetRogueShopBuffInfoCsReq._parser;
			}
		}

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x0600590C RID: 22796 RVA: 0x000EDA8C File Offset: 0x000EBC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueShopBuffInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x0600590D RID: 22797 RVA: 0x000EDA9E File Offset: 0x000EBC9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueShopBuffInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x000EDAA5 File Offset: 0x000EBCA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopBuffInfoCsReq()
		{
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x000EDAAD File Offset: 0x000EBCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopBuffInfoCsReq(GetRogueShopBuffInfoCsReq other) : this()
		{
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this.pUNKLORDOPERATIONREFRESH_ = other.pUNKLORDOPERATIONREFRESH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x000EDADE File Offset: 0x000EBCDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueShopBuffInfoCsReq Clone()
		{
			return new GetRogueShopBuffInfoCsReq(this);
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x06005911 RID: 22801 RVA: 0x000EDAE6 File Offset: 0x000EBCE6
		// (set) Token: 0x06005912 RID: 22802 RVA: 0x000EDAEE File Offset: 0x000EBCEE
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

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x06005913 RID: 22803 RVA: 0x000EDAF7 File Offset: 0x000EBCF7
		// (set) Token: 0x06005914 RID: 22804 RVA: 0x000EDAFF File Offset: 0x000EBCFF
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

		// Token: 0x06005915 RID: 22805 RVA: 0x000EDB08 File Offset: 0x000EBD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueShopBuffInfoCsReq);
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x000EDB16 File Offset: 0x000EBD16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueShopBuffInfoCsReq other)
		{
			return other != null && (other == this || (this.InteractedPropEntityId == other.InteractedPropEntityId && this.PUNKLORDOPERATIONREFRESH == other.PUNKLORDOPERATIONREFRESH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x000EDB54 File Offset: 0x000EBD54
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

		// Token: 0x06005918 RID: 22808 RVA: 0x000EDBAC File Offset: 0x000EBDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x000EDBB4 File Offset: 0x000EBDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x000EDBC0 File Offset: 0x000EBDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PUNKLORDOPERATIONREFRESH)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.PUNKLORDOPERATIONREFRESH);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x000EDC1C File Offset: 0x000EBE1C
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

		// Token: 0x0600591C RID: 22812 RVA: 0x000EDC68 File Offset: 0x000EBE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueShopBuffInfoCsReq other)
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

		// Token: 0x0600591D RID: 22813 RVA: 0x000EDCB8 File Offset: 0x000EBEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x000EDCC4 File Offset: 0x000EBEC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 40U)
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

		// Token: 0x0400229F RID: 8863
		private static readonly MessageParser<GetRogueShopBuffInfoCsReq> _parser = new MessageParser<GetRogueShopBuffInfoCsReq>(() => new GetRogueShopBuffInfoCsReq());

		// Token: 0x040022A0 RID: 8864
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022A1 RID: 8865
		public const int InteractedPropEntityIdFieldNumber = 5;

		// Token: 0x040022A2 RID: 8866
		private uint interactedPropEntityId_;

		// Token: 0x040022A3 RID: 8867
		public const int PUNKLORDOPERATIONREFRESHFieldNumber = 4;

		// Token: 0x040022A4 RID: 8868
		private bool pUNKLORDOPERATIONREFRESH_;
	}
}
