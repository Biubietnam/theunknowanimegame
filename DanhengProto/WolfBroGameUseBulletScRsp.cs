using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001433 RID: 5171
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameUseBulletScRsp : IMessage<WolfBroGameUseBulletScRsp>, IMessage, IEquatable<WolfBroGameUseBulletScRsp>, IDeepCloneable<WolfBroGameUseBulletScRsp>, IBufferMessage
	{
		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x0600E6B0 RID: 59056 RVA: 0x0026519F File Offset: 0x0026339F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameUseBulletScRsp> Parser
		{
			get
			{
				return WolfBroGameUseBulletScRsp._parser;
			}
		}

		// Token: 0x170040C2 RID: 16578
		// (get) Token: 0x0600E6B1 RID: 59057 RVA: 0x002651A6 File Offset: 0x002633A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameUseBulletScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170040C3 RID: 16579
		// (get) Token: 0x0600E6B2 RID: 59058 RVA: 0x002651B8 File Offset: 0x002633B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameUseBulletScRsp.Descriptor;
			}
		}

		// Token: 0x0600E6B3 RID: 59059 RVA: 0x002651BF File Offset: 0x002633BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameUseBulletScRsp()
		{
		}

		// Token: 0x0600E6B4 RID: 59060 RVA: 0x002651C8 File Offset: 0x002633C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameUseBulletScRsp(WolfBroGameUseBulletScRsp other) : this()
		{
			this.wolfBroGameData_ = ((other.wolfBroGameData_ != null) ? other.wolfBroGameData_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E6B5 RID: 59061 RVA: 0x00265214 File Offset: 0x00263414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameUseBulletScRsp Clone()
		{
			return new WolfBroGameUseBulletScRsp(this);
		}

		// Token: 0x170040C4 RID: 16580
		// (get) Token: 0x0600E6B6 RID: 59062 RVA: 0x0026521C File Offset: 0x0026341C
		// (set) Token: 0x0600E6B7 RID: 59063 RVA: 0x00265224 File Offset: 0x00263424
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

		// Token: 0x170040C5 RID: 16581
		// (get) Token: 0x0600E6B8 RID: 59064 RVA: 0x0026522D File Offset: 0x0026342D
		// (set) Token: 0x0600E6B9 RID: 59065 RVA: 0x00265235 File Offset: 0x00263435
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

		// Token: 0x0600E6BA RID: 59066 RVA: 0x0026523E File Offset: 0x0026343E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameUseBulletScRsp);
		}

		// Token: 0x0600E6BB RID: 59067 RVA: 0x0026524C File Offset: 0x0026344C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameUseBulletScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.WolfBroGameData, other.WolfBroGameData) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E6BC RID: 59068 RVA: 0x0026529C File Offset: 0x0026349C
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

		// Token: 0x0600E6BD RID: 59069 RVA: 0x002652F1 File Offset: 0x002634F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E6BE RID: 59070 RVA: 0x002652F9 File Offset: 0x002634F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E6BF RID: 59071 RVA: 0x00265304 File Offset: 0x00263504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.wolfBroGameData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.WolfBroGameData);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E6C0 RID: 59072 RVA: 0x00265360 File Offset: 0x00263560
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

		// Token: 0x0600E6C1 RID: 59073 RVA: 0x002653B8 File Offset: 0x002635B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameUseBulletScRsp other)
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

		// Token: 0x0600E6C2 RID: 59074 RVA: 0x00265420 File Offset: 0x00263620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E6C3 RID: 59075 RVA: 0x0026542C File Offset: 0x0026362C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 80U)
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

		// Token: 0x04005B8A RID: 23434
		private static readonly MessageParser<WolfBroGameUseBulletScRsp> _parser = new MessageParser<WolfBroGameUseBulletScRsp>(() => new WolfBroGameUseBulletScRsp());

		// Token: 0x04005B8B RID: 23435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B8C RID: 23436
		public const int WolfBroGameDataFieldNumber = 9;

		// Token: 0x04005B8D RID: 23437
		private WolfBroGameData wolfBroGameData_;

		// Token: 0x04005B8E RID: 23438
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04005B8F RID: 23439
		private uint retcode_;
	}
}
