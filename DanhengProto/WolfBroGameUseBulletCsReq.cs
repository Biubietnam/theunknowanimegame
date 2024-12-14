using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001431 RID: 5169
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameUseBulletCsReq : IMessage<WolfBroGameUseBulletCsReq>, IMessage, IEquatable<WolfBroGameUseBulletCsReq>, IDeepCloneable<WolfBroGameUseBulletCsReq>, IBufferMessage
	{
		// Token: 0x170040BB RID: 16571
		// (get) Token: 0x0600E69A RID: 59034 RVA: 0x00264DEB File Offset: 0x00262FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameUseBulletCsReq> Parser
		{
			get
			{
				return WolfBroGameUseBulletCsReq._parser;
			}
		}

		// Token: 0x170040BC RID: 16572
		// (get) Token: 0x0600E69B RID: 59035 RVA: 0x00264DF2 File Offset: 0x00262FF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameUseBulletCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040BD RID: 16573
		// (get) Token: 0x0600E69C RID: 59036 RVA: 0x00264E04 File Offset: 0x00263004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameUseBulletCsReq.Descriptor;
			}
		}

		// Token: 0x0600E69D RID: 59037 RVA: 0x00264E0B File Offset: 0x0026300B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameUseBulletCsReq()
		{
		}

		// Token: 0x0600E69E RID: 59038 RVA: 0x00264E20 File Offset: 0x00263020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameUseBulletCsReq(WolfBroGameUseBulletCsReq other) : this()
		{
			this.pPFJLCCFCOJ_ = ((other.pPFJLCCFCOJ_ != null) ? other.pPFJLCCFCOJ_.Clone() : null);
			this.assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E69F RID: 59039 RVA: 0x00264E71 File Offset: 0x00263071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameUseBulletCsReq Clone()
		{
			return new WolfBroGameUseBulletCsReq(this);
		}

		// Token: 0x170040BE RID: 16574
		// (get) Token: 0x0600E6A0 RID: 59040 RVA: 0x00264E79 File Offset: 0x00263079
		// (set) Token: 0x0600E6A1 RID: 59041 RVA: 0x00264E81 File Offset: 0x00263081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector PPFJLCCFCOJ
		{
			get
			{
				return this.pPFJLCCFCOJ_;
			}
			set
			{
				this.pPFJLCCFCOJ_ = value;
			}
		}

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x0600E6A2 RID: 59042 RVA: 0x00264E8A File Offset: 0x0026308A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AssistMonsterEntityIdList
		{
			get
			{
				return this.assistMonsterEntityIdList_;
			}
		}

		// Token: 0x0600E6A3 RID: 59043 RVA: 0x00264E92 File Offset: 0x00263092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameUseBulletCsReq);
		}

		// Token: 0x0600E6A4 RID: 59044 RVA: 0x00264EA0 File Offset: 0x002630A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameUseBulletCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.PPFJLCCFCOJ, other.PPFJLCCFCOJ) && this.assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6A5 RID: 59045 RVA: 0x00264EF4 File Offset: 0x002630F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pPFJLCCFCOJ_ != null)
			{
				num ^= this.PPFJLCCFCOJ.GetHashCode();
			}
			num ^= this.assistMonsterEntityIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E6A6 RID: 59046 RVA: 0x00264F3E File Offset: 0x0026313E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E6A7 RID: 59047 RVA: 0x00264F46 File Offset: 0x00263146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6A8 RID: 59048 RVA: 0x00264F50 File Offset: 0x00263150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pPFJLCCFCOJ_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.PPFJLCCFCOJ);
			}
			this.assistMonsterEntityIdList_.WriteTo(ref output, WolfBroGameUseBulletCsReq._repeated_assistMonsterEntityIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6A9 RID: 59049 RVA: 0x00264FA0 File Offset: 0x002631A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pPFJLCCFCOJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PPFJLCCFCOJ);
			}
			num += this.assistMonsterEntityIdList_.CalculateSize(WolfBroGameUseBulletCsReq._repeated_assistMonsterEntityIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E6AA RID: 59050 RVA: 0x00264FF4 File Offset: 0x002631F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameUseBulletCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pPFJLCCFCOJ_ != null)
			{
				if (this.pPFJLCCFCOJ_ == null)
				{
					this.PPFJLCCFCOJ = new Vector();
				}
				this.PPFJLCCFCOJ.MergeFrom(other.PPFJLCCFCOJ);
			}
			this.assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E6AB RID: 59051 RVA: 0x00265059 File Offset: 0x00263259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6AC RID: 59052 RVA: 0x00265064 File Offset: 0x00263264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					if (num != 112U && num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.assistMonsterEntityIdList_.AddEntriesFrom(ref input, WolfBroGameUseBulletCsReq._repeated_assistMonsterEntityIdList_codec);
					}
				}
				else
				{
					if (this.pPFJLCCFCOJ_ == null)
					{
						this.PPFJLCCFCOJ = new Vector();
					}
					input.ReadMessage(this.PPFJLCCFCOJ);
				}
			}
		}

		// Token: 0x04005B82 RID: 23426
		private static readonly MessageParser<WolfBroGameUseBulletCsReq> _parser = new MessageParser<WolfBroGameUseBulletCsReq>(() => new WolfBroGameUseBulletCsReq());

		// Token: 0x04005B83 RID: 23427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B84 RID: 23428
		public const int PPFJLCCFCOJFieldNumber = 13;

		// Token: 0x04005B85 RID: 23429
		private Vector pPFJLCCFCOJ_;

		// Token: 0x04005B86 RID: 23430
		public const int AssistMonsterEntityIdListFieldNumber = 14;

		// Token: 0x04005B87 RID: 23431
		private static readonly FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04005B88 RID: 23432
		private readonly RepeatedField<uint> assistMonsterEntityIdList_ = new RepeatedField<uint>();
	}
}
