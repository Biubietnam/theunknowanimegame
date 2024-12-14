using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000895 RID: 2197
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HDGPKBGIHNB : IMessage<HDGPKBGIHNB>, IMessage, IEquatable<HDGPKBGIHNB>, IDeepCloneable<HDGPKBGIHNB>, IBufferMessage
	{
		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x00106AFC File Offset: 0x00104CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HDGPKBGIHNB> Parser
		{
			get
			{
				return HDGPKBGIHNB._parser;
			}
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06006214 RID: 25108 RVA: 0x00106B03 File Offset: 0x00104D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HDGPKBGIHNBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06006215 RID: 25109 RVA: 0x00106B15 File Offset: 0x00104D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HDGPKBGIHNB.Descriptor;
			}
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x00106B1C File Offset: 0x00104D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HDGPKBGIHNB()
		{
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x00106B24 File Offset: 0x00104D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HDGPKBGIHNB(HDGPKBGIHNB other) : this()
		{
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x00106B49 File Offset: 0x00104D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HDGPKBGIHNB Clone()
		{
			return new HDGPKBGIHNB(this);
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06006219 RID: 25113 RVA: 0x00106B51 File Offset: 0x00104D51
		// (set) Token: 0x0600621A RID: 25114 RVA: 0x00106B59 File Offset: 0x00104D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x00106B62 File Offset: 0x00104D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HDGPKBGIHNB);
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x00106B70 File Offset: 0x00104D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HDGPKBGIHNB other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x00106BA0 File Offset: 0x00104DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x00106BDF File Offset: 0x00104DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x00106BE7 File Offset: 0x00104DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x00106BF0 File Offset: 0x00104DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x00106C24 File Offset: 0x00104E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x00106C62 File Offset: 0x00104E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HDGPKBGIHNB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x00106C93 File Offset: 0x00104E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x00106C9C File Offset: 0x00104E9C
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
					this.EventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040025BB RID: 9659
		private static readonly MessageParser<HDGPKBGIHNB> _parser = new MessageParser<HDGPKBGIHNB>(() => new HDGPKBGIHNB());

		// Token: 0x040025BC RID: 9660
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025BD RID: 9661
		public const int EventIdFieldNumber = 6;

		// Token: 0x040025BE RID: 9662
		private uint eventId_;
	}
}
