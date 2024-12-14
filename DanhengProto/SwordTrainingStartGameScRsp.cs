using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200124F RID: 4687
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingStartGameScRsp : IMessage<SwordTrainingStartGameScRsp>, IMessage, IEquatable<SwordTrainingStartGameScRsp>, IDeepCloneable<SwordTrainingStartGameScRsp>, IBufferMessage
	{
		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0600D14C RID: 53580 RVA: 0x0022FE0D File Offset: 0x0022E00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingStartGameScRsp> Parser
		{
			get
			{
				return SwordTrainingStartGameScRsp._parser;
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x0600D14D RID: 53581 RVA: 0x0022FE14 File Offset: 0x0022E014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingStartGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x0600D14E RID: 53582 RVA: 0x0022FE26 File Offset: 0x0022E026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingStartGameScRsp.Descriptor;
			}
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x0022FE2D File Offset: 0x0022E02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStartGameScRsp()
		{
		}

		// Token: 0x0600D150 RID: 53584 RVA: 0x0022FE38 File Offset: 0x0022E038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStartGameScRsp(SwordTrainingStartGameScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bEDINILDMEB_ = ((other.bEDINILDMEB_ != null) ? other.bEDINILDMEB_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D151 RID: 53585 RVA: 0x0022FE84 File Offset: 0x0022E084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStartGameScRsp Clone()
		{
			return new SwordTrainingStartGameScRsp(this);
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0600D152 RID: 53586 RVA: 0x0022FE8C File Offset: 0x0022E08C
		// (set) Token: 0x0600D153 RID: 53587 RVA: 0x0022FE94 File Offset: 0x0022E094
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

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x0600D154 RID: 53588 RVA: 0x0022FE9D File Offset: 0x0022E09D
		// (set) Token: 0x0600D155 RID: 53589 RVA: 0x0022FEA5 File Offset: 0x0022E0A5
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

		// Token: 0x0600D156 RID: 53590 RVA: 0x0022FEAE File Offset: 0x0022E0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingStartGameScRsp);
		}

		// Token: 0x0600D157 RID: 53591 RVA: 0x0022FEBC File Offset: 0x0022E0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingStartGameScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BEDINILDMEB, other.BEDINILDMEB) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D158 RID: 53592 RVA: 0x0022FF0C File Offset: 0x0022E10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.bEDINILDMEB_ != null)
			{
				num ^= this.BEDINILDMEB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D159 RID: 53593 RVA: 0x0022FF61 File Offset: 0x0022E161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D15A RID: 53594 RVA: 0x0022FF69 File Offset: 0x0022E169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D15B RID: 53595 RVA: 0x0022FF74 File Offset: 0x0022E174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
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

		// Token: 0x0600D15C RID: 53596 RVA: 0x0022FFD0 File Offset: 0x0022E1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.bEDINILDMEB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BEDINILDMEB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D15D RID: 53597 RVA: 0x00230028 File Offset: 0x0022E228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingStartGameScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.bEDINILDMEB_ != null)
			{
				if (this.bEDINILDMEB_ == null)
				{
					this.BEDINILDMEB = new HPPHNMBHEEJ();
				}
				this.BEDINILDMEB.MergeFrom(other.BEDINILDMEB);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D15E RID: 53598 RVA: 0x00230090 File Offset: 0x0022E290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D15F RID: 53599 RVA: 0x0023009C File Offset: 0x0022E29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
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

		// Token: 0x040053FF RID: 21503
		private static readonly MessageParser<SwordTrainingStartGameScRsp> _parser = new MessageParser<SwordTrainingStartGameScRsp>(() => new SwordTrainingStartGameScRsp());

		// Token: 0x04005400 RID: 21504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005401 RID: 21505
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04005402 RID: 21506
		private uint retcode_;

		// Token: 0x04005403 RID: 21507
		public const int BEDINILDMEBFieldNumber = 8;

		// Token: 0x04005404 RID: 21508
		private HPPHNMBHEEJ bEDINILDMEB_;
	}
}
