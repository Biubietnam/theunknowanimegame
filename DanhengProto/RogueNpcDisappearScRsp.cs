using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F5F RID: 3935
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueNpcDisappearScRsp : IMessage<RogueNpcDisappearScRsp>, IMessage, IEquatable<RogueNpcDisappearScRsp>, IDeepCloneable<RogueNpcDisappearScRsp>, IBufferMessage
	{
		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600AF67 RID: 44903 RVA: 0x001D74E0 File Offset: 0x001D56E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueNpcDisappearScRsp> Parser
		{
			get
			{
				return RogueNpcDisappearScRsp._parser;
			}
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600AF68 RID: 44904 RVA: 0x001D74E7 File Offset: 0x001D56E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueNpcDisappearScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600AF69 RID: 44905 RVA: 0x001D74F9 File Offset: 0x001D56F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueNpcDisappearScRsp.Descriptor;
			}
		}

		// Token: 0x0600AF6A RID: 44906 RVA: 0x001D7500 File Offset: 0x001D5700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueNpcDisappearScRsp()
		{
		}

		// Token: 0x0600AF6B RID: 44907 RVA: 0x001D7508 File Offset: 0x001D5708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueNpcDisappearScRsp(RogueNpcDisappearScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF6C RID: 44908 RVA: 0x001D752D File Offset: 0x001D572D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueNpcDisappearScRsp Clone()
		{
			return new RogueNpcDisappearScRsp(this);
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600AF6D RID: 44909 RVA: 0x001D7535 File Offset: 0x001D5735
		// (set) Token: 0x0600AF6E RID: 44910 RVA: 0x001D753D File Offset: 0x001D573D
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

		// Token: 0x0600AF6F RID: 44911 RVA: 0x001D7546 File Offset: 0x001D5746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueNpcDisappearScRsp);
		}

		// Token: 0x0600AF70 RID: 44912 RVA: 0x001D7554 File Offset: 0x001D5754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueNpcDisappearScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF71 RID: 44913 RVA: 0x001D7584 File Offset: 0x001D5784
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

		// Token: 0x0600AF72 RID: 44914 RVA: 0x001D75C3 File Offset: 0x001D57C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AF73 RID: 44915 RVA: 0x001D75CB File Offset: 0x001D57CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF74 RID: 44916 RVA: 0x001D75D4 File Offset: 0x001D57D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF75 RID: 44917 RVA: 0x001D7608 File Offset: 0x001D5808
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

		// Token: 0x0600AF76 RID: 44918 RVA: 0x001D7646 File Offset: 0x001D5846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueNpcDisappearScRsp other)
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

		// Token: 0x0600AF77 RID: 44919 RVA: 0x001D7677 File Offset: 0x001D5877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF78 RID: 44920 RVA: 0x001D7680 File Offset: 0x001D5880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004759 RID: 18265
		private static readonly MessageParser<RogueNpcDisappearScRsp> _parser = new MessageParser<RogueNpcDisappearScRsp>(() => new RogueNpcDisappearScRsp());

		// Token: 0x0400475A RID: 18266
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400475B RID: 18267
		public const int RetcodeFieldNumber = 6;

		// Token: 0x0400475C RID: 18268
		private uint retcode_;
	}
}
