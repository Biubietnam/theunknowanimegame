using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012F7 RID: 4855
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeOffAvatarSkinScRsp : IMessage<TakeOffAvatarSkinScRsp>, IMessage, IEquatable<TakeOffAvatarSkinScRsp>, IDeepCloneable<TakeOffAvatarSkinScRsp>, IBufferMessage
	{
		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0600D8A1 RID: 55457 RVA: 0x00241A88 File Offset: 0x0023FC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeOffAvatarSkinScRsp> Parser
		{
			get
			{
				return TakeOffAvatarSkinScRsp._parser;
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x0600D8A2 RID: 55458 RVA: 0x00241A8F File Offset: 0x0023FC8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeOffAvatarSkinScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x0600D8A3 RID: 55459 RVA: 0x00241AA1 File Offset: 0x0023FCA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeOffAvatarSkinScRsp.Descriptor;
			}
		}

		// Token: 0x0600D8A4 RID: 55460 RVA: 0x00241AA8 File Offset: 0x0023FCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffAvatarSkinScRsp()
		{
		}

		// Token: 0x0600D8A5 RID: 55461 RVA: 0x00241AB0 File Offset: 0x0023FCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffAvatarSkinScRsp(TakeOffAvatarSkinScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8A6 RID: 55462 RVA: 0x00241AD5 File Offset: 0x0023FCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOffAvatarSkinScRsp Clone()
		{
			return new TakeOffAvatarSkinScRsp(this);
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x0600D8A7 RID: 55463 RVA: 0x00241ADD File Offset: 0x0023FCDD
		// (set) Token: 0x0600D8A8 RID: 55464 RVA: 0x00241AE5 File Offset: 0x0023FCE5
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

		// Token: 0x0600D8A9 RID: 55465 RVA: 0x00241AEE File Offset: 0x0023FCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeOffAvatarSkinScRsp);
		}

		// Token: 0x0600D8AA RID: 55466 RVA: 0x00241AFC File Offset: 0x0023FCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeOffAvatarSkinScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8AB RID: 55467 RVA: 0x00241B2C File Offset: 0x0023FD2C
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

		// Token: 0x0600D8AC RID: 55468 RVA: 0x00241B6B File Offset: 0x0023FD6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D8AD RID: 55469 RVA: 0x00241B73 File Offset: 0x0023FD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8AE RID: 55470 RVA: 0x00241B7C File Offset: 0x0023FD7C
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

		// Token: 0x0600D8AF RID: 55471 RVA: 0x00241BB0 File Offset: 0x0023FDB0
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

		// Token: 0x0600D8B0 RID: 55472 RVA: 0x00241BEE File Offset: 0x0023FDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeOffAvatarSkinScRsp other)
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

		// Token: 0x0600D8B1 RID: 55473 RVA: 0x00241C1F File Offset: 0x0023FE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8B2 RID: 55474 RVA: 0x00241C28 File Offset: 0x0023FE28
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

		// Token: 0x0400566D RID: 22125
		private static readonly MessageParser<TakeOffAvatarSkinScRsp> _parser = new MessageParser<TakeOffAvatarSkinScRsp>(() => new TakeOffAvatarSkinScRsp());

		// Token: 0x0400566E RID: 22126
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400566F RID: 22127
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04005670 RID: 22128
		private uint retcode_;
	}
}
