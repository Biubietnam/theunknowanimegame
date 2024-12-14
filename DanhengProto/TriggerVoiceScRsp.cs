using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013AD RID: 5037
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TriggerVoiceScRsp : IMessage<TriggerVoiceScRsp>, IMessage, IEquatable<TriggerVoiceScRsp>, IDeepCloneable<TriggerVoiceScRsp>, IBufferMessage
	{
		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0600E0BB RID: 57531 RVA: 0x002565B0 File Offset: 0x002547B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TriggerVoiceScRsp> Parser
		{
			get
			{
				return TriggerVoiceScRsp._parser;
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x0600E0BC RID: 57532 RVA: 0x002565B7 File Offset: 0x002547B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TriggerVoiceScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x0600E0BD RID: 57533 RVA: 0x002565C9 File Offset: 0x002547C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerVoiceScRsp.Descriptor;
			}
		}

		// Token: 0x0600E0BE RID: 57534 RVA: 0x002565D0 File Offset: 0x002547D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerVoiceScRsp()
		{
		}

		// Token: 0x0600E0BF RID: 57535 RVA: 0x002565D8 File Offset: 0x002547D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerVoiceScRsp(TriggerVoiceScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0C0 RID: 57536 RVA: 0x002565FD File Offset: 0x002547FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerVoiceScRsp Clone()
		{
			return new TriggerVoiceScRsp(this);
		}

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x0600E0C1 RID: 57537 RVA: 0x00256605 File Offset: 0x00254805
		// (set) Token: 0x0600E0C2 RID: 57538 RVA: 0x0025660D File Offset: 0x0025480D
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

		// Token: 0x0600E0C3 RID: 57539 RVA: 0x00256616 File Offset: 0x00254816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerVoiceScRsp);
		}

		// Token: 0x0600E0C4 RID: 57540 RVA: 0x00256624 File Offset: 0x00254824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerVoiceScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0C5 RID: 57541 RVA: 0x00256654 File Offset: 0x00254854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600E0C6 RID: 57542 RVA: 0x00256693 File Offset: 0x00254893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E0C7 RID: 57543 RVA: 0x0025669B File Offset: 0x0025489B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0C8 RID: 57544 RVA: 0x002566A4 File Offset: 0x002548A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0C9 RID: 57545 RVA: 0x002566D8 File Offset: 0x002548D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600E0CA RID: 57546 RVA: 0x00256716 File Offset: 0x00254916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerVoiceScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0CB RID: 57547 RVA: 0x00256747 File Offset: 0x00254947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0CC RID: 57548 RVA: 0x00256750 File Offset: 0x00254950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400597B RID: 22907
		private static readonly MessageParser<TriggerVoiceScRsp> _parser = new MessageParser<TriggerVoiceScRsp>(() => new TriggerVoiceScRsp());

		// Token: 0x0400597C RID: 22908
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400597D RID: 22909
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400597E RID: 22910
		private uint retcode_;
	}
}
