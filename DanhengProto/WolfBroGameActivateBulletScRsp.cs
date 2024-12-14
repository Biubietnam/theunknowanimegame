using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001421 RID: 5153
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class WolfBroGameActivateBulletScRsp : IMessage<WolfBroGameActivateBulletScRsp>, IMessage, IEquatable<WolfBroGameActivateBulletScRsp>, IDeepCloneable<WolfBroGameActivateBulletScRsp>, IBufferMessage
	{
		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x0600E5E3 RID: 58851 RVA: 0x0026318C File Offset: 0x0026138C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WolfBroGameActivateBulletScRsp> Parser
		{
			get
			{
				return WolfBroGameActivateBulletScRsp._parser;
			}
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x0600E5E4 RID: 58852 RVA: 0x00263193 File Offset: 0x00261393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return WolfBroGameActivateBulletScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x0600E5E5 RID: 58853 RVA: 0x002631A5 File Offset: 0x002613A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WolfBroGameActivateBulletScRsp.Descriptor;
			}
		}

		// Token: 0x0600E5E6 RID: 58854 RVA: 0x002631AC File Offset: 0x002613AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameActivateBulletScRsp()
		{
		}

		// Token: 0x0600E5E7 RID: 58855 RVA: 0x002631B4 File Offset: 0x002613B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameActivateBulletScRsp(WolfBroGameActivateBulletScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E5E8 RID: 58856 RVA: 0x002631D9 File Offset: 0x002613D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WolfBroGameActivateBulletScRsp Clone()
		{
			return new WolfBroGameActivateBulletScRsp(this);
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x0600E5E9 RID: 58857 RVA: 0x002631E1 File Offset: 0x002613E1
		// (set) Token: 0x0600E5EA RID: 58858 RVA: 0x002631E9 File Offset: 0x002613E9
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

		// Token: 0x0600E5EB RID: 58859 RVA: 0x002631F2 File Offset: 0x002613F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WolfBroGameActivateBulletScRsp);
		}

		// Token: 0x0600E5EC RID: 58860 RVA: 0x00263200 File Offset: 0x00261400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WolfBroGameActivateBulletScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E5ED RID: 58861 RVA: 0x00263230 File Offset: 0x00261430
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

		// Token: 0x0600E5EE RID: 58862 RVA: 0x0026326F File Offset: 0x0026146F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E5EF RID: 58863 RVA: 0x00263277 File Offset: 0x00261477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E5F0 RID: 58864 RVA: 0x00263280 File Offset: 0x00261480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E5F1 RID: 58865 RVA: 0x002632B4 File Offset: 0x002614B4
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

		// Token: 0x0600E5F2 RID: 58866 RVA: 0x002632F2 File Offset: 0x002614F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WolfBroGameActivateBulletScRsp other)
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

		// Token: 0x0600E5F3 RID: 58867 RVA: 0x00263323 File Offset: 0x00261523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E5F4 RID: 58868 RVA: 0x0026332C File Offset: 0x0026152C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005B45 RID: 23365
		private static readonly MessageParser<WolfBroGameActivateBulletScRsp> _parser = new MessageParser<WolfBroGameActivateBulletScRsp>(() => new WolfBroGameActivateBulletScRsp());

		// Token: 0x04005B46 RID: 23366
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B47 RID: 23367
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04005B48 RID: 23368
		private uint retcode_;
	}
}
