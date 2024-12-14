using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001257 RID: 4695
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingStoryConfirmScRsp : IMessage<SwordTrainingStoryConfirmScRsp>, IMessage, IEquatable<SwordTrainingStoryConfirmScRsp>, IDeepCloneable<SwordTrainingStoryConfirmScRsp>, IBufferMessage
	{
		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0600D1A2 RID: 53666 RVA: 0x00230971 File Offset: 0x0022EB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingStoryConfirmScRsp> Parser
		{
			get
			{
				return SwordTrainingStoryConfirmScRsp._parser;
			}
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0600D1A3 RID: 53667 RVA: 0x00230978 File Offset: 0x0022EB78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingStoryConfirmScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0600D1A4 RID: 53668 RVA: 0x0023098A File Offset: 0x0022EB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingStoryConfirmScRsp.Descriptor;
			}
		}

		// Token: 0x0600D1A5 RID: 53669 RVA: 0x00230991 File Offset: 0x0022EB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryConfirmScRsp()
		{
		}

		// Token: 0x0600D1A6 RID: 53670 RVA: 0x00230999 File Offset: 0x0022EB99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryConfirmScRsp(SwordTrainingStoryConfirmScRsp other) : this()
		{
			this.cOJGEGHIADI_ = other.cOJGEGHIADI_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1A7 RID: 53671 RVA: 0x002309CA File Offset: 0x0022EBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryConfirmScRsp Clone()
		{
			return new SwordTrainingStoryConfirmScRsp(this);
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0600D1A8 RID: 53672 RVA: 0x002309D2 File Offset: 0x0022EBD2
		// (set) Token: 0x0600D1A9 RID: 53673 RVA: 0x002309DA File Offset: 0x0022EBDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COJGEGHIADI
		{
			get
			{
				return this.cOJGEGHIADI_;
			}
			set
			{
				this.cOJGEGHIADI_ = value;
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x0600D1AA RID: 53674 RVA: 0x002309E3 File Offset: 0x0022EBE3
		// (set) Token: 0x0600D1AB RID: 53675 RVA: 0x002309EB File Offset: 0x0022EBEB
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

		// Token: 0x0600D1AC RID: 53676 RVA: 0x002309F4 File Offset: 0x0022EBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingStoryConfirmScRsp);
		}

		// Token: 0x0600D1AD RID: 53677 RVA: 0x00230A02 File Offset: 0x0022EC02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingStoryConfirmScRsp other)
		{
			return other != null && (other == this || (this.COJGEGHIADI == other.COJGEGHIADI && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1AE RID: 53678 RVA: 0x00230A40 File Offset: 0x0022EC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.COJGEGHIADI != 0U)
			{
				num ^= this.COJGEGHIADI.GetHashCode();
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

		// Token: 0x0600D1AF RID: 53679 RVA: 0x00230A98 File Offset: 0x0022EC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D1B0 RID: 53680 RVA: 0x00230AA0 File Offset: 0x0022ECA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1B1 RID: 53681 RVA: 0x00230AAC File Offset: 0x0022ECAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.COJGEGHIADI != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1B2 RID: 53682 RVA: 0x00230B04 File Offset: 0x0022ED04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.COJGEGHIADI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COJGEGHIADI);
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

		// Token: 0x0600D1B3 RID: 53683 RVA: 0x00230B5C File Offset: 0x0022ED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingStoryConfirmScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.COJGEGHIADI != 0U)
			{
				this.COJGEGHIADI = other.COJGEGHIADI;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1B4 RID: 53684 RVA: 0x00230BAC File Offset: 0x0022EDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1B5 RID: 53685 RVA: 0x00230BB8 File Offset: 0x0022EDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.COJGEGHIADI = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005415 RID: 21525
		private static readonly MessageParser<SwordTrainingStoryConfirmScRsp> _parser = new MessageParser<SwordTrainingStoryConfirmScRsp>(() => new SwordTrainingStoryConfirmScRsp());

		// Token: 0x04005416 RID: 21526
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005417 RID: 21527
		public const int COJGEGHIADIFieldNumber = 4;

		// Token: 0x04005418 RID: 21528
		private uint cOJGEGHIADI_;

		// Token: 0x04005419 RID: 21529
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400541A RID: 21530
		private uint retcode_;
	}
}
