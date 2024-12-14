using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000585 RID: 1413
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishItemIdScRsp : IMessage<FinishItemIdScRsp>, IMessage, IEquatable<FinishItemIdScRsp>, IDeepCloneable<FinishItemIdScRsp>, IBufferMessage
	{
		// Token: 0x170011F0 RID: 4592
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x000AC249 File Offset: 0x000AA449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishItemIdScRsp> Parser
		{
			get
			{
				return FinishItemIdScRsp._parser;
			}
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x000AC250 File Offset: 0x000AA450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishItemIdScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x000AC262 File Offset: 0x000AA462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishItemIdScRsp.Descriptor;
			}
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x000AC269 File Offset: 0x000AA469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishItemIdScRsp()
		{
		}

		// Token: 0x06003F10 RID: 16144 RVA: 0x000AC271 File Offset: 0x000AA471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishItemIdScRsp(FinishItemIdScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.textId_ = other.textId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x000AC2AE File Offset: 0x000AA4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishItemIdScRsp Clone()
		{
			return new FinishItemIdScRsp(this);
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x000AC2B6 File Offset: 0x000AA4B6
		// (set) Token: 0x06003F13 RID: 16147 RVA: 0x000AC2BE File Offset: 0x000AA4BE
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

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x000AC2C7 File Offset: 0x000AA4C7
		// (set) Token: 0x06003F15 RID: 16149 RVA: 0x000AC2CF File Offset: 0x000AA4CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TextId
		{
			get
			{
				return this.textId_;
			}
			set
			{
				this.textId_ = value;
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x000AC2D8 File Offset: 0x000AA4D8
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x000AC2E0 File Offset: 0x000AA4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x000AC2E9 File Offset: 0x000AA4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishItemIdScRsp);
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x000AC2F8 File Offset: 0x000AA4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishItemIdScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.TextId == other.TextId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x000AC354 File Offset: 0x000AA554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.TextId != 0U)
			{
				num ^= this.TextId.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x000AC3C5 File Offset: 0x000AA5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x000AC3CD File Offset: 0x000AA5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x000AC3D8 File Offset: 0x000AA5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.ItemId);
			}
			if (this.TextId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.TextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x000AC450 File Offset: 0x000AA650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.TextId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TextId);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x000AC4C0 File Offset: 0x000AA6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishItemIdScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.TextId != 0U)
			{
				this.TextId = other.TextId;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x000AC524 File Offset: 0x000AA724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x000AC530 File Offset: 0x000AA730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 96U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TextId = input.ReadUInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400191D RID: 6429
		private static readonly MessageParser<FinishItemIdScRsp> _parser = new MessageParser<FinishItemIdScRsp>(() => new FinishItemIdScRsp());

		// Token: 0x0400191E RID: 6430
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400191F RID: 6431
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001920 RID: 6432
		private uint retcode_;

		// Token: 0x04001921 RID: 6433
		public const int TextIdFieldNumber = 14;

		// Token: 0x04001922 RID: 6434
		private uint textId_;

		// Token: 0x04001923 RID: 6435
		public const int ItemIdFieldNumber = 12;

		// Token: 0x04001924 RID: 6436
		private uint itemId_;
	}
}
