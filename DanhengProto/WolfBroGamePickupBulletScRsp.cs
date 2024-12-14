using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200142F RID: 5167
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGamePickupBulletScRsp : IMessage<WolfBroGamePickupBulletScRsp>, IMessage, IEquatable<WolfBroGamePickupBulletScRsp>, IDeepCloneable<WolfBroGamePickupBulletScRsp>, IBufferMessage
	{
		// Token: 0x170040B5 RID: 16565
		// (get) Token: 0x0600E683 RID: 59011 RVA: 0x00264A3B File Offset: 0x00262C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGamePickupBulletScRsp> Parser
		{
			get
			{
				return WolfBroGamePickupBulletScRsp._parser;
			}
		}

		// Token: 0x170040B6 RID: 16566
		// (get) Token: 0x0600E684 RID: 59012 RVA: 0x00264A42 File Offset: 0x00262C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGamePickupBulletScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040B7 RID: 16567
		// (get) Token: 0x0600E685 RID: 59013 RVA: 0x00264A54 File Offset: 0x00262C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGamePickupBulletScRsp.Descriptor;
			}
		}

		// Token: 0x0600E686 RID: 59014 RVA: 0x00264A5B File Offset: 0x00262C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGamePickupBulletScRsp()
		{
		}

		// Token: 0x0600E687 RID: 59015 RVA: 0x00264A64 File Offset: 0x00262C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGamePickupBulletScRsp(WolfBroGamePickupBulletScRsp other) : this()
		{
			this.wolfBroGameData_ = ((other.wolfBroGameData_ != null) ? other.wolfBroGameData_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E688 RID: 59016 RVA: 0x00264AB0 File Offset: 0x00262CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGamePickupBulletScRsp Clone()
		{
			return new WolfBroGamePickupBulletScRsp(this);
		}

		// Token: 0x170040B8 RID: 16568
		// (get) Token: 0x0600E689 RID: 59017 RVA: 0x00264AB8 File Offset: 0x00262CB8
		// (set) Token: 0x0600E68A RID: 59018 RVA: 0x00264AC0 File Offset: 0x00262CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameData WolfBroGameData
		{
			get
			{
				return this.wolfBroGameData_;
			}
			set
			{
				this.wolfBroGameData_ = value;
			}
		}

		// Token: 0x170040B9 RID: 16569
		// (get) Token: 0x0600E68B RID: 59019 RVA: 0x00264AC9 File Offset: 0x00262CC9
		// (set) Token: 0x0600E68C RID: 59020 RVA: 0x00264AD1 File Offset: 0x00262CD1
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

		// Token: 0x0600E68D RID: 59021 RVA: 0x00264ADA File Offset: 0x00262CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGamePickupBulletScRsp);
		}

		// Token: 0x0600E68E RID: 59022 RVA: 0x00264AE8 File Offset: 0x00262CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGamePickupBulletScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.WolfBroGameData, other.WolfBroGameData) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E68F RID: 59023 RVA: 0x00264B38 File Offset: 0x00262D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.wolfBroGameData_ != null)
			{
				num ^= this.WolfBroGameData.GetHashCode();
			}
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

		// Token: 0x0600E690 RID: 59024 RVA: 0x00264B8D File Offset: 0x00262D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E691 RID: 59025 RVA: 0x00264B95 File Offset: 0x00262D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E692 RID: 59026 RVA: 0x00264BA0 File Offset: 0x00262DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.wolfBroGameData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.WolfBroGameData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E693 RID: 59027 RVA: 0x00264BFC File Offset: 0x00262DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.wolfBroGameData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.WolfBroGameData);
			}
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

		// Token: 0x0600E694 RID: 59028 RVA: 0x00264C54 File Offset: 0x00262E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGamePickupBulletScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.wolfBroGameData_ != null)
			{
				if (this.wolfBroGameData_ == null)
				{
					this.WolfBroGameData = new WolfBroGameData();
				}
				this.WolfBroGameData.MergeFrom(other.WolfBroGameData);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E695 RID: 59029 RVA: 0x00264CBC File Offset: 0x00262EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E696 RID: 59030 RVA: 0x00264CC8 File Offset: 0x00262EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.wolfBroGameData_ == null)
					{
						this.WolfBroGameData = new WolfBroGameData();
					}
					input.ReadMessage(this.WolfBroGameData);
				}
			}
		}

		// Token: 0x04005B7B RID: 23419
		private static readonly MessageParser<WolfBroGamePickupBulletScRsp> _parser = new MessageParser<WolfBroGamePickupBulletScRsp>(() => new WolfBroGamePickupBulletScRsp());

		// Token: 0x04005B7C RID: 23420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B7D RID: 23421
		public const int WolfBroGameDataFieldNumber = 3;

		// Token: 0x04005B7E RID: 23422
		private WolfBroGameData wolfBroGameData_;

		// Token: 0x04005B7F RID: 23423
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04005B80 RID: 23424
		private uint retcode_;
	}
}
