using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200123F RID: 4671
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingRestoreGameScRsp : IMessage<SwordTrainingRestoreGameScRsp>, IMessage, IEquatable<SwordTrainingRestoreGameScRsp>, IDeepCloneable<SwordTrainingRestoreGameScRsp>, IBufferMessage
	{
		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x0600D09C RID: 53404 RVA: 0x0022E6AF File Offset: 0x0022C8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingRestoreGameScRsp> Parser
		{
			get
			{
				return SwordTrainingRestoreGameScRsp._parser;
			}
		}

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x0600D09D RID: 53405 RVA: 0x0022E6B6 File Offset: 0x0022C8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingRestoreGameScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x0600D09E RID: 53406 RVA: 0x0022E6C8 File Offset: 0x0022C8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingRestoreGameScRsp.Descriptor;
			}
		}

		// Token: 0x0600D09F RID: 53407 RVA: 0x0022E6CF File Offset: 0x0022C8CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingRestoreGameScRsp()
		{
		}

		// Token: 0x0600D0A0 RID: 53408 RVA: 0x0022E6D8 File Offset: 0x0022C8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingRestoreGameScRsp(SwordTrainingRestoreGameScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.bEDINILDMEB_ = ((other.bEDINILDMEB_ != null) ? other.bEDINILDMEB_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0A1 RID: 53409 RVA: 0x0022E724 File Offset: 0x0022C924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingRestoreGameScRsp Clone()
		{
			return new SwordTrainingRestoreGameScRsp(this);
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x0600D0A2 RID: 53410 RVA: 0x0022E72C File Offset: 0x0022C92C
		// (set) Token: 0x0600D0A3 RID: 53411 RVA: 0x0022E734 File Offset: 0x0022C934
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

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x0600D0A4 RID: 53412 RVA: 0x0022E73D File Offset: 0x0022C93D
		// (set) Token: 0x0600D0A5 RID: 53413 RVA: 0x0022E745 File Offset: 0x0022C945
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

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x0022E74E File Offset: 0x0022C94E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingRestoreGameScRsp);
		}

		// Token: 0x0600D0A7 RID: 53415 RVA: 0x0022E75C File Offset: 0x0022C95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingRestoreGameScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.BEDINILDMEB, other.BEDINILDMEB) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0A8 RID: 53416 RVA: 0x0022E7AC File Offset: 0x0022C9AC
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

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x0022E801 File Offset: 0x0022CA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D0AA RID: 53418 RVA: 0x0022E809 File Offset: 0x0022CA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0AB RID: 53419 RVA: 0x0022E814 File Offset: 0x0022CA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bEDINILDMEB_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.BEDINILDMEB);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0AC RID: 53420 RVA: 0x0022E870 File Offset: 0x0022CA70
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

		// Token: 0x0600D0AD RID: 53421 RVA: 0x0022E8C8 File Offset: 0x0022CAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingRestoreGameScRsp other)
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

		// Token: 0x0600D0AE RID: 53422 RVA: 0x0022E930 File Offset: 0x0022CB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0AF RID: 53423 RVA: 0x0022E93C File Offset: 0x0022CB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 64U)
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
					if (this.bEDINILDMEB_ == null)
					{
						this.BEDINILDMEB = new HPPHNMBHEEJ();
					}
					input.ReadMessage(this.BEDINILDMEB);
				}
			}
		}

		// Token: 0x040053CF RID: 21455
		private static readonly MessageParser<SwordTrainingRestoreGameScRsp> _parser = new MessageParser<SwordTrainingRestoreGameScRsp>(() => new SwordTrainingRestoreGameScRsp());

		// Token: 0x040053D0 RID: 21456
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053D1 RID: 21457
		public const int RetcodeFieldNumber = 8;

		// Token: 0x040053D2 RID: 21458
		private uint retcode_;

		// Token: 0x040053D3 RID: 21459
		public const int BEDINILDMEBFieldNumber = 7;

		// Token: 0x040053D4 RID: 21460
		private HPPHNMBHEEJ bEDINILDMEB_;
	}
}
