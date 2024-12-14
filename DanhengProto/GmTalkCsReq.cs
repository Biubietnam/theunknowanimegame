using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000869 RID: 2153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GmTalkCsReq : IMessage<GmTalkCsReq>, IMessage, IEquatable<GmTalkCsReq>, IDeepCloneable<GmTalkCsReq>, IBufferMessage
	{
		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06005FAE RID: 24494 RVA: 0x000FD10B File Offset: 0x000FB30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmTalkCsReq> Parser
		{
			get
			{
				return GmTalkCsReq._parser;
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x06005FAF RID: 24495 RVA: 0x000FD112 File Offset: 0x000FB312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GmTalkCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x06005FB0 RID: 24496 RVA: 0x000FD124 File Offset: 0x000FB324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmTalkCsReq.Descriptor;
			}
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x000FD12B File Offset: 0x000FB32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkCsReq()
		{
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x000FD13E File Offset: 0x000FB33E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkCsReq(GmTalkCsReq other) : this()
		{
			this.msg_ = other.msg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x000FD163 File Offset: 0x000FB363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkCsReq Clone()
		{
			return new GmTalkCsReq(this);
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x06005FB4 RID: 24500 RVA: 0x000FD16B File Offset: 0x000FB36B
		// (set) Token: 0x06005FB5 RID: 24501 RVA: 0x000FD173 File Offset: 0x000FB373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Msg
		{
			get
			{
				return this.msg_;
			}
			set
			{
				this.msg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x000FD186 File Offset: 0x000FB386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmTalkCsReq);
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x000FD194 File Offset: 0x000FB394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmTalkCsReq other)
		{
			return other != null && (other == this || (!(this.Msg != other.Msg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x000FD1C8 File Offset: 0x000FB3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Msg.Length != 0)
			{
				num ^= this.Msg.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x000FD209 File Offset: 0x000FB409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x000FD211 File Offset: 0x000FB411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x000FD21A File Offset: 0x000FB41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Msg.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.Msg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x000FD254 File Offset: 0x000FB454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Msg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Msg);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x000FD297 File Offset: 0x000FB497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmTalkCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Msg.Length != 0)
			{
				this.Msg = other.Msg;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x000FD2CD File Offset: 0x000FB4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x000FD2D8 File Offset: 0x000FB4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Msg = input.ReadString();
				}
			}
		}

		// Token: 0x040024CE RID: 9422
		private static readonly MessageParser<GmTalkCsReq> _parser = new MessageParser<GmTalkCsReq>(() => new GmTalkCsReq());

		// Token: 0x040024CF RID: 9423
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024D0 RID: 9424
		public const int MsgFieldNumber = 9;

		// Token: 0x040024D1 RID: 9425
		private string msg_ = "";
	}
}
