using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200121F RID: 4639
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingDailyPhaseConfirmCsReq : IMessage<SwordTrainingDailyPhaseConfirmCsReq>, IMessage, IEquatable<SwordTrainingDailyPhaseConfirmCsReq>, IDeepCloneable<SwordTrainingDailyPhaseConfirmCsReq>, IBufferMessage
	{
		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0600CF58 RID: 53080 RVA: 0x0022BD27 File Offset: 0x00229F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingDailyPhaseConfirmCsReq> Parser
		{
			get
			{
				return SwordTrainingDailyPhaseConfirmCsReq._parser;
			}
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x0600CF59 RID: 53081 RVA: 0x0022BD2E File Offset: 0x00229F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingDailyPhaseConfirmCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x0600CF5A RID: 53082 RVA: 0x0022BD40 File Offset: 0x00229F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingDailyPhaseConfirmCsReq.Descriptor;
			}
		}

		// Token: 0x0600CF5B RID: 53083 RVA: 0x0022BD47 File Offset: 0x00229F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDailyPhaseConfirmCsReq()
		{
		}

		// Token: 0x0600CF5C RID: 53084 RVA: 0x0022BD4F File Offset: 0x00229F4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDailyPhaseConfirmCsReq(SwordTrainingDailyPhaseConfirmCsReq other) : this()
		{
			this.oMMPPEPNCNH_ = other.oMMPPEPNCNH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF5D RID: 53085 RVA: 0x0022BD74 File Offset: 0x00229F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDailyPhaseConfirmCsReq Clone()
		{
			return new SwordTrainingDailyPhaseConfirmCsReq(this);
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x0600CF5E RID: 53086 RVA: 0x0022BD7C File Offset: 0x00229F7C
		// (set) Token: 0x0600CF5F RID: 53087 RVA: 0x0022BD84 File Offset: 0x00229F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDailyPhaseType OMMPPEPNCNH
		{
			get
			{
				return this.oMMPPEPNCNH_;
			}
			set
			{
				this.oMMPPEPNCNH_ = value;
			}
		}

		// Token: 0x0600CF60 RID: 53088 RVA: 0x0022BD8D File Offset: 0x00229F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingDailyPhaseConfirmCsReq);
		}

		// Token: 0x0600CF61 RID: 53089 RVA: 0x0022BD9B File Offset: 0x00229F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingDailyPhaseConfirmCsReq other)
		{
			return other != null && (other == this || (this.OMMPPEPNCNH == other.OMMPPEPNCNH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF62 RID: 53090 RVA: 0x0022BDCC File Offset: 0x00229FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OMMPPEPNCNH != SwordTrainingDailyPhaseType.None)
			{
				num ^= this.OMMPPEPNCNH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF63 RID: 53091 RVA: 0x0022BE11 File Offset: 0x0022A011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CF64 RID: 53092 RVA: 0x0022BE19 File Offset: 0x0022A019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x0022BE22 File Offset: 0x0022A022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OMMPPEPNCNH != SwordTrainingDailyPhaseType.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.OMMPPEPNCNH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF66 RID: 53094 RVA: 0x0022BE54 File Offset: 0x0022A054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OMMPPEPNCNH != SwordTrainingDailyPhaseType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OMMPPEPNCNH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x0022BE92 File Offset: 0x0022A092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingDailyPhaseConfirmCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OMMPPEPNCNH != SwordTrainingDailyPhaseType.None)
			{
				this.OMMPPEPNCNH = other.OMMPPEPNCNH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x0022BEC3 File Offset: 0x0022A0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x0022BECC File Offset: 0x0022A0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.OMMPPEPNCNH = (SwordTrainingDailyPhaseType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005370 RID: 21360
		private static readonly MessageParser<SwordTrainingDailyPhaseConfirmCsReq> _parser = new MessageParser<SwordTrainingDailyPhaseConfirmCsReq>(() => new SwordTrainingDailyPhaseConfirmCsReq());

		// Token: 0x04005371 RID: 21361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005372 RID: 21362
		public const int OMMPPEPNCNHFieldNumber = 15;

		// Token: 0x04005373 RID: 21363
		private SwordTrainingDailyPhaseType oMMPPEPNCNH_;
	}
}
