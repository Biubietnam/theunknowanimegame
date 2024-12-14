using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003A1 RID: 929
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DifficultyAdjustmentUpdateDataCsReq : IMessage<DifficultyAdjustmentUpdateDataCsReq>, IMessage, IEquatable<DifficultyAdjustmentUpdateDataCsReq>, IDeepCloneable<DifficultyAdjustmentUpdateDataCsReq>, IBufferMessage
	{
		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x00072A31 File Offset: 0x00070C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DifficultyAdjustmentUpdateDataCsReq> Parser
		{
			get
			{
				return DifficultyAdjustmentUpdateDataCsReq._parser;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x0600293C RID: 10556 RVA: 0x00072A38 File Offset: 0x00070C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DifficultyAdjustmentUpdateDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x00072A4A File Offset: 0x00070C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DifficultyAdjustmentUpdateDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x00072A51 File Offset: 0x00070C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentUpdateDataCsReq()
		{
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00072A59 File Offset: 0x00070C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentUpdateDataCsReq(DifficultyAdjustmentUpdateDataCsReq other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x00072A8E File Offset: 0x00070C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DifficultyAdjustmentUpdateDataCsReq Clone()
		{
			return new DifficultyAdjustmentUpdateDataCsReq(this);
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x00072A96 File Offset: 0x00070C96
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x00072A9E File Offset: 0x00070C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FPGKHIFENGL Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00072AA7 File Offset: 0x00070CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DifficultyAdjustmentUpdateDataCsReq);
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x00072AB5 File Offset: 0x00070CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DifficultyAdjustmentUpdateDataCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x00072AE8 File Offset: 0x00070CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x00072B24 File Offset: 0x00070D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x00072B2C File Offset: 0x00070D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00072B35 File Offset: 0x00070D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00072B68 File Offset: 0x00070D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00072BA8 File Offset: 0x00070DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DifficultyAdjustmentUpdateDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new FPGKHIFENGL();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00072BFC File Offset: 0x00070DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00072C08 File Offset: 0x00070E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.data_ == null)
					{
						this.Data = new FPGKHIFENGL();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x040010A3 RID: 4259
		private static readonly MessageParser<DifficultyAdjustmentUpdateDataCsReq> _parser = new MessageParser<DifficultyAdjustmentUpdateDataCsReq>(() => new DifficultyAdjustmentUpdateDataCsReq());

		// Token: 0x040010A4 RID: 4260
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010A5 RID: 4261
		public const int DataFieldNumber = 12;

		// Token: 0x040010A6 RID: 4262
		private FPGKHIFENGL data_;
	}
}
