using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001247 RID: 4679
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingSelectEndingScRsp : IMessage<SwordTrainingSelectEndingScRsp>, IMessage, IEquatable<SwordTrainingSelectEndingScRsp>, IDeepCloneable<SwordTrainingSelectEndingScRsp>, IBufferMessage
	{
		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0600D0F4 RID: 53492 RVA: 0x0022F2B5 File Offset: 0x0022D4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingSelectEndingScRsp> Parser
		{
			get
			{
				return SwordTrainingSelectEndingScRsp._parser;
			}
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x0600D0F5 RID: 53493 RVA: 0x0022F2BC File Offset: 0x0022D4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingSelectEndingScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x0600D0F6 RID: 53494 RVA: 0x0022F2CE File Offset: 0x0022D4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingSelectEndingScRsp.Descriptor;
			}
		}

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x0022F2D5 File Offset: 0x0022D4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSelectEndingScRsp()
		{
		}

		// Token: 0x0600D0F8 RID: 53496 RVA: 0x0022F2DD File Offset: 0x0022D4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSelectEndingScRsp(SwordTrainingSelectEndingScRsp other) : this()
		{
			this.aMDMIAEJNEM_ = other.aMDMIAEJNEM_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0F9 RID: 53497 RVA: 0x0022F30E File Offset: 0x0022D50E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSelectEndingScRsp Clone()
		{
			return new SwordTrainingSelectEndingScRsp(this);
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x0600D0FA RID: 53498 RVA: 0x0022F316 File Offset: 0x0022D516
		// (set) Token: 0x0600D0FB RID: 53499 RVA: 0x0022F31E File Offset: 0x0022D51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AMDMIAEJNEM
		{
			get
			{
				return this.aMDMIAEJNEM_;
			}
			set
			{
				this.aMDMIAEJNEM_ = value;
			}
		}

		// Token: 0x17003AE0 RID: 15072
		// (get) Token: 0x0600D0FC RID: 53500 RVA: 0x0022F327 File Offset: 0x0022D527
		// (set) Token: 0x0600D0FD RID: 53501 RVA: 0x0022F32F File Offset: 0x0022D52F
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

		// Token: 0x0600D0FE RID: 53502 RVA: 0x0022F338 File Offset: 0x0022D538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingSelectEndingScRsp);
		}

		// Token: 0x0600D0FF RID: 53503 RVA: 0x0022F346 File Offset: 0x0022D546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingSelectEndingScRsp other)
		{
			return other != null && (other == this || (this.AMDMIAEJNEM == other.AMDMIAEJNEM && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D100 RID: 53504 RVA: 0x0022F384 File Offset: 0x0022D584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AMDMIAEJNEM != 0U)
			{
				num ^= this.AMDMIAEJNEM.GetHashCode();
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

		// Token: 0x0600D101 RID: 53505 RVA: 0x0022F3DC File Offset: 0x0022D5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D102 RID: 53506 RVA: 0x0022F3E4 File Offset: 0x0022D5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D103 RID: 53507 RVA: 0x0022F3F0 File Offset: 0x0022D5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.AMDMIAEJNEM != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.AMDMIAEJNEM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D104 RID: 53508 RVA: 0x0022F44C File Offset: 0x0022D64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AMDMIAEJNEM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AMDMIAEJNEM);
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

		// Token: 0x0600D105 RID: 53509 RVA: 0x0022F4A4 File Offset: 0x0022D6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingSelectEndingScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AMDMIAEJNEM != 0U)
			{
				this.AMDMIAEJNEM = other.AMDMIAEJNEM;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D106 RID: 53510 RVA: 0x0022F4F4 File Offset: 0x0022D6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D107 RID: 53511 RVA: 0x0022F500 File Offset: 0x0022D700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AMDMIAEJNEM = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053E7 RID: 21479
		private static readonly MessageParser<SwordTrainingSelectEndingScRsp> _parser = new MessageParser<SwordTrainingSelectEndingScRsp>(() => new SwordTrainingSelectEndingScRsp());

		// Token: 0x040053E8 RID: 21480
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053E9 RID: 21481
		public const int AMDMIAEJNEMFieldNumber = 15;

		// Token: 0x040053EA RID: 21482
		private uint aMDMIAEJNEM_;

		// Token: 0x040053EB RID: 21483
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040053EC RID: 21484
		private uint retcode_;
	}
}
