using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001221 RID: 4641
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingDailyPhaseConfirmScRsp : IMessage<SwordTrainingDailyPhaseConfirmScRsp>, IMessage, IEquatable<SwordTrainingDailyPhaseConfirmScRsp>, IDeepCloneable<SwordTrainingDailyPhaseConfirmScRsp>, IBufferMessage
	{
		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x0600CF6D RID: 53101 RVA: 0x0022BFA9 File Offset: 0x0022A1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingDailyPhaseConfirmScRsp> Parser
		{
			get
			{
				return SwordTrainingDailyPhaseConfirmScRsp._parser;
			}
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x0600CF6E RID: 53102 RVA: 0x0022BFB0 File Offset: 0x0022A1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingDailyPhaseConfirmScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x0600CF6F RID: 53103 RVA: 0x0022BFC2 File Offset: 0x0022A1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingDailyPhaseConfirmScRsp.Descriptor;
			}
		}

		// Token: 0x0600CF70 RID: 53104 RVA: 0x0022BFC9 File Offset: 0x0022A1C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDailyPhaseConfirmScRsp()
		{
		}

		// Token: 0x0600CF71 RID: 53105 RVA: 0x0022BFD1 File Offset: 0x0022A1D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDailyPhaseConfirmScRsp(SwordTrainingDailyPhaseConfirmScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.kPPNOJGEDNM_ = other.kPPNOJGEDNM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF72 RID: 53106 RVA: 0x0022C002 File Offset: 0x0022A202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingDailyPhaseConfirmScRsp Clone()
		{
			return new SwordTrainingDailyPhaseConfirmScRsp(this);
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0600CF73 RID: 53107 RVA: 0x0022C00A File Offset: 0x0022A20A
		// (set) Token: 0x0600CF74 RID: 53108 RVA: 0x0022C012 File Offset: 0x0022A212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0600CF75 RID: 53109 RVA: 0x0022C01B File Offset: 0x0022A21B
		// (set) Token: 0x0600CF76 RID: 53110 RVA: 0x0022C023 File Offset: 0x0022A223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KPPNOJGEDNM
		{
			get
			{
				return this.kPPNOJGEDNM_;
			}
			set
			{
				this.kPPNOJGEDNM_ = value;
			}
		}

		// Token: 0x0600CF77 RID: 53111 RVA: 0x0022C02C File Offset: 0x0022A22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingDailyPhaseConfirmScRsp);
		}

		// Token: 0x0600CF78 RID: 53112 RVA: 0x0022C03A File Offset: 0x0022A23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingDailyPhaseConfirmScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.KPPNOJGEDNM == other.KPPNOJGEDNM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF79 RID: 53113 RVA: 0x0022C078 File Offset: 0x0022A278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.KPPNOJGEDNM)
			{
				num ^= this.KPPNOJGEDNM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF7A RID: 53114 RVA: 0x0022C0D0 File Offset: 0x0022A2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CF7B RID: 53115 RVA: 0x0022C0D8 File Offset: 0x0022A2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF7C RID: 53116 RVA: 0x0022C0E4 File Offset: 0x0022A2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KPPNOJGEDNM)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.KPPNOJGEDNM);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF7D RID: 53117 RVA: 0x0022C140 File Offset: 0x0022A340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.KPPNOJGEDNM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF7E RID: 53118 RVA: 0x0022C18C File Offset: 0x0022A38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingDailyPhaseConfirmScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.KPPNOJGEDNM)
			{
				this.KPPNOJGEDNM = other.KPPNOJGEDNM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF7F RID: 53119 RVA: 0x0022C1DC File Offset: 0x0022A3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF80 RID: 53120 RVA: 0x0022C1E8 File Offset: 0x0022A3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.KPPNOJGEDNM = input.ReadBool();
				}
			}
		}

		// Token: 0x04005375 RID: 21365
		private static readonly MessageParser<SwordTrainingDailyPhaseConfirmScRsp> _parser = new MessageParser<SwordTrainingDailyPhaseConfirmScRsp>(() => new SwordTrainingDailyPhaseConfirmScRsp());

		// Token: 0x04005376 RID: 21366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005377 RID: 21367
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04005378 RID: 21368
		private uint retcode_;

		// Token: 0x04005379 RID: 21369
		public const int KPPNOJGEDNMFieldNumber = 2;

		// Token: 0x0400537A RID: 21370
		private bool kPPNOJGEDNM_;
	}
}
