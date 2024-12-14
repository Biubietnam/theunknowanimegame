using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000041 RID: 65
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddBlacklistCsReq : IMessage<AddBlacklistCsReq>, IMessage, IEquatable<AddBlacklistCsReq>, IDeepCloneable<AddBlacklistCsReq>, IBufferMessage
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000828C File Offset: 0x0000648C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddBlacklistCsReq> Parser
		{
			get
			{
				return AddBlacklistCsReq._parser;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00008293 File Offset: 0x00006493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AddBlacklistCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000082A5 File Offset: 0x000064A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddBlacklistCsReq.Descriptor;
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000082AC File Offset: 0x000064AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBlacklistCsReq()
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000082B4 File Offset: 0x000064B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBlacklistCsReq(AddBlacklistCsReq other) : this()
		{
			this.uid_ = other.uid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000082D9 File Offset: 0x000064D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddBlacklistCsReq Clone()
		{
			return new AddBlacklistCsReq(this);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000289 RID: 649 RVA: 0x000082E1 File Offset: 0x000064E1
		// (set) Token: 0x0600028A RID: 650 RVA: 0x000082E9 File Offset: 0x000064E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000082F2 File Offset: 0x000064F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddBlacklistCsReq);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00008300 File Offset: 0x00006500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddBlacklistCsReq other)
		{
			return other != null && (other == this || (this.Uid == other.Uid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00008330 File Offset: 0x00006530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000836F File Offset: 0x0000656F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00008377 File Offset: 0x00006577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00008380 File Offset: 0x00006580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Uid != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000083B4 File Offset: 0x000065B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000083F2 File Offset: 0x000065F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddBlacklistCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00008423 File Offset: 0x00006623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000842C File Offset: 0x0000662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Uid = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040000EB RID: 235
		private static readonly MessageParser<AddBlacklistCsReq> _parser = new MessageParser<AddBlacklistCsReq>(() => new AddBlacklistCsReq());

		// Token: 0x040000EC RID: 236
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000ED RID: 237
		public const int UidFieldNumber = 10;

		// Token: 0x040000EE RID: 238
		private uint uid_;
	}
}
