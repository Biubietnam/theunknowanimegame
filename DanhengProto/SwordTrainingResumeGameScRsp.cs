using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001243 RID: 4675
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingResumeGameScRsp : IMessage<SwordTrainingResumeGameScRsp>, IMessage, IEquatable<SwordTrainingResumeGameScRsp>, IDeepCloneable<SwordTrainingResumeGameScRsp>, IBufferMessage
	{
		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x0600D0C8 RID: 53448 RVA: 0x0022ECB9 File Offset: 0x0022CEB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingResumeGameScRsp> Parser
		{
			get
			{
				return SwordTrainingResumeGameScRsp._parser;
			}
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x0600D0C9 RID: 53449 RVA: 0x0022ECC0 File Offset: 0x0022CEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingResumeGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x0600D0CA RID: 53450 RVA: 0x0022ECD2 File Offset: 0x0022CED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingResumeGameScRsp.Descriptor;
			}
		}

		// Token: 0x0600D0CB RID: 53451 RVA: 0x0022ECD9 File Offset: 0x0022CED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingResumeGameScRsp()
		{
		}

		// Token: 0x0600D0CC RID: 53452 RVA: 0x0022ECE4 File Offset: 0x0022CEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingResumeGameScRsp(SwordTrainingResumeGameScRsp other) : this()
		{
			this.bEDINILDMEB_ = ((other.bEDINILDMEB_ != null) ? other.bEDINILDMEB_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0CD RID: 53453 RVA: 0x0022ED30 File Offset: 0x0022CF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingResumeGameScRsp Clone()
		{
			return new SwordTrainingResumeGameScRsp(this);
		}

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x0600D0CE RID: 53454 RVA: 0x0022ED38 File Offset: 0x0022CF38
		// (set) Token: 0x0600D0CF RID: 53455 RVA: 0x0022ED40 File Offset: 0x0022CF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HPPHNMBHEEJ BEDINILDMEB
		{
			get
			{
				return this.bEDINILDMEB_;
			}
			set
			{
				this.bEDINILDMEB_ = value;
			}
		}

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x0600D0D0 RID: 53456 RVA: 0x0022ED49 File Offset: 0x0022CF49
		// (set) Token: 0x0600D0D1 RID: 53457 RVA: 0x0022ED51 File Offset: 0x0022CF51
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

		// Token: 0x0600D0D2 RID: 53458 RVA: 0x0022ED5A File Offset: 0x0022CF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingResumeGameScRsp);
		}

		// Token: 0x0600D0D3 RID: 53459 RVA: 0x0022ED68 File Offset: 0x0022CF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingResumeGameScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BEDINILDMEB, other.BEDINILDMEB) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0D4 RID: 53460 RVA: 0x0022EDB8 File Offset: 0x0022CFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bEDINILDMEB_ != null)
			{
				num ^= this.BEDINILDMEB.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0D5 RID: 53461 RVA: 0x0022EE0D File Offset: 0x0022D00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D0D6 RID: 53462 RVA: 0x0022EE15 File Offset: 0x0022D015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0D7 RID: 53463 RVA: 0x0022EE20 File Offset: 0x0022D020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.bEDINILDMEB_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.BEDINILDMEB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0D8 RID: 53464 RVA: 0x0022EE7C File Offset: 0x0022D07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bEDINILDMEB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BEDINILDMEB);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0D9 RID: 53465 RVA: 0x0022EED4 File Offset: 0x0022D0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingResumeGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bEDINILDMEB_ != null)
			{
				if (this.bEDINILDMEB_ == null)
				{
					this.BEDINILDMEB = new HPPHNMBHEEJ();
				}
				this.BEDINILDMEB.MergeFrom(other.BEDINILDMEB);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0DA RID: 53466 RVA: 0x0022EF3C File Offset: 0x0022D13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0DB RID: 53467 RVA: 0x0022EF48 File Offset: 0x0022D148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.bEDINILDMEB_ == null)
						{
							this.BEDINILDMEB = new HPPHNMBHEEJ();
						}
						input.ReadMessage(this.BEDINILDMEB);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053DB RID: 21467
		private static readonly MessageParser<SwordTrainingResumeGameScRsp> _parser = new MessageParser<SwordTrainingResumeGameScRsp>(() => new SwordTrainingResumeGameScRsp());

		// Token: 0x040053DC RID: 21468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053DD RID: 21469
		public const int BEDINILDMEBFieldNumber = 8;

		// Token: 0x040053DE RID: 21470
		private HPPHNMBHEEJ bEDINILDMEB_;

		// Token: 0x040053DF RID: 21471
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040053E0 RID: 21472
		private uint retcode_;
	}
}
