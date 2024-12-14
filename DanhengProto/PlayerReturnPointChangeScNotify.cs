using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CD5 RID: 3285
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnPointChangeScNotify : IMessage<PlayerReturnPointChangeScNotify>, IMessage, IEquatable<PlayerReturnPointChangeScNotify>, IDeepCloneable<PlayerReturnPointChangeScNotify>, IBufferMessage
	{
		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x0600928A RID: 37514 RVA: 0x00184AFC File Offset: 0x00182CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnPointChangeScNotify> Parser
		{
			get
			{
				return PlayerReturnPointChangeScNotify._parser;
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x0600928B RID: 37515 RVA: 0x00184B03 File Offset: 0x00182D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnPointChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x0600928C RID: 37516 RVA: 0x00184B15 File Offset: 0x00182D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnPointChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600928D RID: 37517 RVA: 0x00184B1C File Offset: 0x00182D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnPointChangeScNotify()
		{
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x00184B24 File Offset: 0x00182D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnPointChangeScNotify(PlayerReturnPointChangeScNotify other) : this()
		{
			this.hDDGPMMNICD_ = other.hDDGPMMNICD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x00184B49 File Offset: 0x00182D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnPointChangeScNotify Clone()
		{
			return new PlayerReturnPointChangeScNotify(this);
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x06009290 RID: 37520 RVA: 0x00184B51 File Offset: 0x00182D51
		// (set) Token: 0x06009291 RID: 37521 RVA: 0x00184B59 File Offset: 0x00182D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HDDGPMMNICD
		{
			get
			{
				return this.hDDGPMMNICD_;
			}
			set
			{
				this.hDDGPMMNICD_ = value;
			}
		}

		// Token: 0x06009292 RID: 37522 RVA: 0x00184B62 File Offset: 0x00182D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnPointChangeScNotify);
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x00184B70 File Offset: 0x00182D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnPointChangeScNotify other)
		{
			return other != null && (other == this || (this.HDDGPMMNICD == other.HDDGPMMNICD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009294 RID: 37524 RVA: 0x00184BA0 File Offset: 0x00182DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HDDGPMMNICD != 0U)
			{
				num ^= this.HDDGPMMNICD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009295 RID: 37525 RVA: 0x00184BDF File Offset: 0x00182DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009296 RID: 37526 RVA: 0x00184BE7 File Offset: 0x00182DE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009297 RID: 37527 RVA: 0x00184BF0 File Offset: 0x00182DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HDDGPMMNICD != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.HDDGPMMNICD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009298 RID: 37528 RVA: 0x00184C24 File Offset: 0x00182E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HDDGPMMNICD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HDDGPMMNICD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009299 RID: 37529 RVA: 0x00184C62 File Offset: 0x00182E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnPointChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HDDGPMMNICD != 0U)
			{
				this.HDDGPMMNICD = other.HDDGPMMNICD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600929A RID: 37530 RVA: 0x00184C93 File Offset: 0x00182E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600929B RID: 37531 RVA: 0x00184C9C File Offset: 0x00182E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HDDGPMMNICD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400388A RID: 14474
		private static readonly MessageParser<PlayerReturnPointChangeScNotify> _parser = new MessageParser<PlayerReturnPointChangeScNotify>(() => new PlayerReturnPointChangeScNotify());

		// Token: 0x0400388B RID: 14475
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400388C RID: 14476
		public const int HDDGPMMNICDFieldNumber = 4;

		// Token: 0x0400388D RID: 14477
		private uint hDDGPMMNICD_;
	}
}
