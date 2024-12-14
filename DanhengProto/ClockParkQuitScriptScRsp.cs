using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002FB RID: 763
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkQuitScriptScRsp : IMessage<ClockParkQuitScriptScRsp>, IMessage, IEquatable<ClockParkQuitScriptScRsp>, IDeepCloneable<ClockParkQuitScriptScRsp>, IBufferMessage
	{
		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x00061390 File Offset: 0x0005F590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkQuitScriptScRsp> Parser
		{
			get
			{
				return ClockParkQuitScriptScRsp._parser;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600221F RID: 8735 RVA: 0x00061397 File Offset: 0x0005F597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkQuitScriptScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x000613A9 File Offset: 0x0005F5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkQuitScriptScRsp.Descriptor;
			}
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000613B0 File Offset: 0x0005F5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkQuitScriptScRsp()
		{
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x000613B8 File Offset: 0x0005F5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkQuitScriptScRsp(ClockParkQuitScriptScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x000613DD File Offset: 0x0005F5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkQuitScriptScRsp Clone()
		{
			return new ClockParkQuitScriptScRsp(this);
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000613E5 File Offset: 0x0005F5E5
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x000613ED File Offset: 0x0005F5ED
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

		// Token: 0x06002226 RID: 8742 RVA: 0x000613F6 File Offset: 0x0005F5F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkQuitScriptScRsp);
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00061404 File Offset: 0x0005F604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkQuitScriptScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00061434 File Offset: 0x0005F634
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

		// Token: 0x06002229 RID: 8745 RVA: 0x00061473 File Offset: 0x0005F673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x0006147B File Offset: 0x0005F67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x00061484 File Offset: 0x0005F684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x000614B8 File Offset: 0x0005F6B8
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

		// Token: 0x0600222D RID: 8749 RVA: 0x000614F6 File Offset: 0x0005F6F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkQuitScriptScRsp other)
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

		// Token: 0x0600222E RID: 8750 RVA: 0x00061527 File Offset: 0x0005F727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x00061530 File Offset: 0x0005F730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000E1B RID: 3611
		private static readonly MessageParser<ClockParkQuitScriptScRsp> _parser = new MessageParser<ClockParkQuitScriptScRsp>(() => new ClockParkQuitScriptScRsp());

		// Token: 0x04000E1C RID: 3612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000E1D RID: 3613
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04000E1E RID: 3614
		private uint retcode_;
	}
}
