using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BAF RID: 2991
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerFightGiveUpScRsp : IMessage<MultiplayerFightGiveUpScRsp>, IMessage, IEquatable<MultiplayerFightGiveUpScRsp>, IDeepCloneable<MultiplayerFightGiveUpScRsp>, IBufferMessage
	{
		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x06008450 RID: 33872 RVA: 0x0015D3D4 File Offset: 0x0015B5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerFightGiveUpScRsp> Parser
		{
			get
			{
				return MultiplayerFightGiveUpScRsp._parser;
			}
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x06008451 RID: 33873 RVA: 0x0015D3DB File Offset: 0x0015B5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerFightGiveUpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x06008452 RID: 33874 RVA: 0x0015D3ED File Offset: 0x0015B5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerFightGiveUpScRsp.Descriptor;
			}
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x0015D3F4 File Offset: 0x0015B5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGiveUpScRsp()
		{
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x0015D3FC File Offset: 0x0015B5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGiveUpScRsp(MultiplayerFightGiveUpScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x0015D421 File Offset: 0x0015B621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGiveUpScRsp Clone()
		{
			return new MultiplayerFightGiveUpScRsp(this);
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x06008456 RID: 33878 RVA: 0x0015D429 File Offset: 0x0015B629
		// (set) Token: 0x06008457 RID: 33879 RVA: 0x0015D431 File Offset: 0x0015B631
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

		// Token: 0x06008458 RID: 33880 RVA: 0x0015D43A File Offset: 0x0015B63A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerFightGiveUpScRsp);
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x0015D448 File Offset: 0x0015B648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerFightGiveUpScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x0015D478 File Offset: 0x0015B678
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

		// Token: 0x0600845B RID: 33883 RVA: 0x0015D4B7 File Offset: 0x0015B6B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x0015D4BF File Offset: 0x0015B6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x0015D4C8 File Offset: 0x0015B6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x0015D4FC File Offset: 0x0015B6FC
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

		// Token: 0x0600845F RID: 33887 RVA: 0x0015D53A File Offset: 0x0015B73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerFightGiveUpScRsp other)
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

		// Token: 0x06008460 RID: 33888 RVA: 0x0015D56B File Offset: 0x0015B76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x0015D574 File Offset: 0x0015B774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040032A9 RID: 12969
		private static readonly MessageParser<MultiplayerFightGiveUpScRsp> _parser = new MessageParser<MultiplayerFightGiveUpScRsp>(() => new MultiplayerFightGiveUpScRsp());

		// Token: 0x040032AA RID: 12970
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032AB RID: 12971
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040032AC RID: 12972
		private uint retcode_;
	}
}
