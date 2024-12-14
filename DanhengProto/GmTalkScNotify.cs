using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200086B RID: 2155
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GmTalkScNotify : IMessage<GmTalkScNotify>, IMessage, IEquatable<GmTalkScNotify>, IDeepCloneable<GmTalkScNotify>, IBufferMessage
	{
		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x000FD3A8 File Offset: 0x000FB5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GmTalkScNotify> Parser
		{
			get
			{
				return GmTalkScNotify._parser;
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06005FC4 RID: 24516 RVA: 0x000FD3AF File Offset: 0x000FB5AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GmTalkScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x000FD3C1 File Offset: 0x000FB5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmTalkScNotify.Descriptor;
			}
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x000FD3C8 File Offset: 0x000FB5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkScNotify()
		{
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x000FD3DB File Offset: 0x000FB5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkScNotify(GmTalkScNotify other) : this()
		{
			this.msg_ = other.msg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x000FD400 File Offset: 0x000FB600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmTalkScNotify Clone()
		{
			return new GmTalkScNotify(this);
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06005FC9 RID: 24521 RVA: 0x000FD408 File Offset: 0x000FB608
		// (set) Token: 0x06005FCA RID: 24522 RVA: 0x000FD410 File Offset: 0x000FB610
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

		// Token: 0x06005FCB RID: 24523 RVA: 0x000FD423 File Offset: 0x000FB623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmTalkScNotify);
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x000FD431 File Offset: 0x000FB631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmTalkScNotify other)
		{
			return other != null && (other == this || (!(this.Msg != other.Msg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x000FD464 File Offset: 0x000FB664
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

		// Token: 0x06005FCE RID: 24526 RVA: 0x000FD4A5 File Offset: 0x000FB6A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x000FD4AD File Offset: 0x000FB6AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x000FD4B6 File Offset: 0x000FB6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Msg.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.Msg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x000FD4F0 File Offset: 0x000FB6F0
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

		// Token: 0x06005FD2 RID: 24530 RVA: 0x000FD533 File Offset: 0x000FB733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmTalkScNotify other)
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

		// Token: 0x06005FD3 RID: 24531 RVA: 0x000FD569 File Offset: 0x000FB769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x000FD574 File Offset: 0x000FB774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Msg = input.ReadString();
				}
			}
		}

		// Token: 0x040024D3 RID: 9427
		private static readonly MessageParser<GmTalkScNotify> _parser = new MessageParser<GmTalkScNotify>(() => new GmTalkScNotify());

		// Token: 0x040024D4 RID: 9428
		private UnknownFieldSet _unknownFields;

		// Token: 0x040024D5 RID: 9429
		public const int MsgFieldNumber = 7;

		// Token: 0x040024D6 RID: 9430
		private string msg_ = "";
	}
}
