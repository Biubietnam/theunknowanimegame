using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005DD RID: 1501
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameplayCounterRecoverCsReq : IMessage<GameplayCounterRecoverCsReq>, IMessage, IEquatable<GameplayCounterRecoverCsReq>, IDeepCloneable<GameplayCounterRecoverCsReq>, IBufferMessage
	{
		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x06004307 RID: 17159 RVA: 0x000B6839 File Offset: 0x000B4A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayCounterRecoverCsReq> Parser
		{
			get
			{
				return GameplayCounterRecoverCsReq._parser;
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x000B6840 File Offset: 0x000B4A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameplayCounterRecoverCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x06004309 RID: 17161 RVA: 0x000B6852 File Offset: 0x000B4A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCounterRecoverCsReq.Descriptor;
			}
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x000B6859 File Offset: 0x000B4A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterRecoverCsReq()
		{
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x000B6861 File Offset: 0x000B4A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterRecoverCsReq(GameplayCounterRecoverCsReq other) : this()
		{
			this.nNCFPDLCNHN_ = other.nNCFPDLCNHN_;
			this.cBIIPJBKLIN_ = other.cBIIPJBKLIN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x000B6892 File Offset: 0x000B4A92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterRecoverCsReq Clone()
		{
			return new GameplayCounterRecoverCsReq(this);
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x0600430D RID: 17165 RVA: 0x000B689A File Offset: 0x000B4A9A
		// (set) Token: 0x0600430E RID: 17166 RVA: 0x000B68A2 File Offset: 0x000B4AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NNCFPDLCNHN
		{
			get
			{
				return this.nNCFPDLCNHN_;
			}
			set
			{
				this.nNCFPDLCNHN_ = value;
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x0600430F RID: 17167 RVA: 0x000B68AB File Offset: 0x000B4AAB
		// (set) Token: 0x06004310 RID: 17168 RVA: 0x000B68B3 File Offset: 0x000B4AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CBIIPJBKLIN
		{
			get
			{
				return this.cBIIPJBKLIN_;
			}
			set
			{
				this.cBIIPJBKLIN_ = value;
			}
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x000B68BC File Offset: 0x000B4ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCounterRecoverCsReq);
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x000B68CA File Offset: 0x000B4ACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCounterRecoverCsReq other)
		{
			return other != null && (other == this || (this.NNCFPDLCNHN == other.NNCFPDLCNHN && this.CBIIPJBKLIN == other.CBIIPJBKLIN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x000B6908 File Offset: 0x000B4B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NNCFPDLCNHN != 0U)
			{
				num ^= this.NNCFPDLCNHN.GetHashCode();
			}
			if (this.CBIIPJBKLIN != 0U)
			{
				num ^= this.CBIIPJBKLIN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x000B6960 File Offset: 0x000B4B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x000B6968 File Offset: 0x000B4B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x000B6974 File Offset: 0x000B4B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NNCFPDLCNHN != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.NNCFPDLCNHN);
			}
			if (this.CBIIPJBKLIN != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.CBIIPJBKLIN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x000B69D0 File Offset: 0x000B4BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NNCFPDLCNHN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NNCFPDLCNHN);
			}
			if (this.CBIIPJBKLIN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CBIIPJBKLIN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x000B6A28 File Offset: 0x000B4C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCounterRecoverCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NNCFPDLCNHN != 0U)
			{
				this.NNCFPDLCNHN = other.NNCFPDLCNHN;
			}
			if (other.CBIIPJBKLIN != 0U)
			{
				this.CBIIPJBKLIN = other.CBIIPJBKLIN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x000B6A78 File Offset: 0x000B4C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x000B6A84 File Offset: 0x000B4C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CBIIPJBKLIN = input.ReadUInt32();
					}
				}
				else
				{
					this.NNCFPDLCNHN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001A9B RID: 6811
		private static readonly MessageParser<GameplayCounterRecoverCsReq> _parser = new MessageParser<GameplayCounterRecoverCsReq>(() => new GameplayCounterRecoverCsReq());

		// Token: 0x04001A9C RID: 6812
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A9D RID: 6813
		public const int NNCFPDLCNHNFieldNumber = 4;

		// Token: 0x04001A9E RID: 6814
		private uint nNCFPDLCNHN_;

		// Token: 0x04001A9F RID: 6815
		public const int CBIIPJBKLINFieldNumber = 12;

		// Token: 0x04001AA0 RID: 6816
		private uint cBIIPJBKLIN_;
	}
}
