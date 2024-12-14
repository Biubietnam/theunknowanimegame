using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D97 RID: 3479
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RegionInfo : IMessage<RegionInfo>, IMessage, IEquatable<RegionInfo>, IDeepCloneable<RegionInfo>, IBufferMessage
	{
		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x06009B5C RID: 39772 RVA: 0x0019D5D9 File Offset: 0x0019B7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RegionInfo> Parser
		{
			get
			{
				return RegionInfo._parser;
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x06009B5D RID: 39773 RVA: 0x0019D5E0 File Offset: 0x0019B7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RegionInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x06009B5E RID: 39774 RVA: 0x0019D5F2 File Offset: 0x0019B7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RegionInfo.Descriptor;
			}
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x0019D5FC File Offset: 0x0019B7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegionInfo()
		{
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x0019D654 File Offset: 0x0019B854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegionInfo(RegionInfo other) : this()
		{
			this.name_ = other.name_;
			this.title_ = other.title_;
			this.dispatchUrl_ = other.dispatchUrl_;
			this.envType_ = other.envType_;
			this.displayName_ = other.displayName_;
			this.msg_ = other.msg_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B61 RID: 39777 RVA: 0x0019D6C0 File Offset: 0x0019B8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RegionInfo Clone()
		{
			return new RegionInfo(this);
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x06009B62 RID: 39778 RVA: 0x0019D6C8 File Offset: 0x0019B8C8
		// (set) Token: 0x06009B63 RID: 39779 RVA: 0x0019D6D0 File Offset: 0x0019B8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06009B64 RID: 39780 RVA: 0x0019D6E3 File Offset: 0x0019B8E3
		// (set) Token: 0x06009B65 RID: 39781 RVA: 0x0019D6EB File Offset: 0x0019B8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Title
		{
			get
			{
				return this.title_;
			}
			set
			{
				this.title_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06009B66 RID: 39782 RVA: 0x0019D6FE File Offset: 0x0019B8FE
		// (set) Token: 0x06009B67 RID: 39783 RVA: 0x0019D706 File Offset: 0x0019B906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DispatchUrl
		{
			get
			{
				return this.dispatchUrl_;
			}
			set
			{
				this.dispatchUrl_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06009B68 RID: 39784 RVA: 0x0019D719 File Offset: 0x0019B919
		// (set) Token: 0x06009B69 RID: 39785 RVA: 0x0019D721 File Offset: 0x0019B921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string EnvType
		{
			get
			{
				return this.envType_;
			}
			set
			{
				this.envType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x06009B6A RID: 39786 RVA: 0x0019D734 File Offset: 0x0019B934
		// (set) Token: 0x06009B6B RID: 39787 RVA: 0x0019D73C File Offset: 0x0019B93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string DisplayName
		{
			get
			{
				return this.displayName_;
			}
			set
			{
				this.displayName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x06009B6C RID: 39788 RVA: 0x0019D74F File Offset: 0x0019B94F
		// (set) Token: 0x06009B6D RID: 39789 RVA: 0x0019D757 File Offset: 0x0019B957
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

		// Token: 0x06009B6E RID: 39790 RVA: 0x0019D76A File Offset: 0x0019B96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RegionInfo);
		}

		// Token: 0x06009B6F RID: 39791 RVA: 0x0019D778 File Offset: 0x0019B978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RegionInfo other)
		{
			return other != null && (other == this || (!(this.Name != other.Name) && !(this.Title != other.Title) && !(this.DispatchUrl != other.DispatchUrl) && !(this.EnvType != other.EnvType) && !(this.DisplayName != other.DisplayName) && !(this.Msg != other.Msg) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B70 RID: 39792 RVA: 0x0019D820 File Offset: 0x0019BA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.Title.Length != 0)
			{
				num ^= this.Title.GetHashCode();
			}
			if (this.DispatchUrl.Length != 0)
			{
				num ^= this.DispatchUrl.GetHashCode();
			}
			if (this.EnvType.Length != 0)
			{
				num ^= this.EnvType.GetHashCode();
			}
			if (this.DisplayName.Length != 0)
			{
				num ^= this.DisplayName.GetHashCode();
			}
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

		// Token: 0x06009B71 RID: 39793 RVA: 0x0019D8E8 File Offset: 0x0019BAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009B72 RID: 39794 RVA: 0x0019D8F0 File Offset: 0x0019BAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B73 RID: 39795 RVA: 0x0019D8FC File Offset: 0x0019BAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Name);
			}
			if (this.Title.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Title);
			}
			if (this.DispatchUrl.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.DispatchUrl);
			}
			if (this.EnvType.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.EnvType);
			}
			if (this.DisplayName.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.DisplayName);
			}
			if (this.Msg.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.Msg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x0019D9E4 File Offset: 0x0019BBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.Title.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Title);
			}
			if (this.DispatchUrl.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DispatchUrl);
			}
			if (this.EnvType.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.EnvType);
			}
			if (this.DisplayName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.DisplayName);
			}
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

		// Token: 0x06009B75 RID: 39797 RVA: 0x0019DAB8 File Offset: 0x0019BCB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RegionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.Title.Length != 0)
			{
				this.Title = other.Title;
			}
			if (other.DispatchUrl.Length != 0)
			{
				this.DispatchUrl = other.DispatchUrl;
			}
			if (other.EnvType.Length != 0)
			{
				this.EnvType = other.EnvType;
			}
			if (other.DisplayName.Length != 0)
			{
				this.DisplayName = other.DisplayName;
			}
			if (other.Msg.Length != 0)
			{
				this.Msg = other.Msg;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B76 RID: 39798 RVA: 0x0019DB76 File Offset: 0x0019BD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B77 RID: 39799 RVA: 0x0019DB80 File Offset: 0x0019BD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 10U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						this.Title = input.ReadString();
						continue;
					}
					if (num == 26U)
					{
						this.DispatchUrl = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.EnvType = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.DisplayName = input.ReadString();
						continue;
					}
					if (num == 50U)
					{
						this.Msg = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C48 RID: 15432
		private static readonly MessageParser<RegionInfo> _parser = new MessageParser<RegionInfo>(() => new RegionInfo());

		// Token: 0x04003C49 RID: 15433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C4A RID: 15434
		public const int NameFieldNumber = 1;

		// Token: 0x04003C4B RID: 15435
		private string name_ = "";

		// Token: 0x04003C4C RID: 15436
		public const int TitleFieldNumber = 2;

		// Token: 0x04003C4D RID: 15437
		private string title_ = "";

		// Token: 0x04003C4E RID: 15438
		public const int DispatchUrlFieldNumber = 3;

		// Token: 0x04003C4F RID: 15439
		private string dispatchUrl_ = "";

		// Token: 0x04003C50 RID: 15440
		public const int EnvTypeFieldNumber = 4;

		// Token: 0x04003C51 RID: 15441
		private string envType_ = "";

		// Token: 0x04003C52 RID: 15442
		public const int DisplayNameFieldNumber = 5;

		// Token: 0x04003C53 RID: 15443
		private string displayName_ = "";

		// Token: 0x04003C54 RID: 15444
		public const int MsgFieldNumber = 6;

		// Token: 0x04003C55 RID: 15445
		private string msg_ = "";
	}
}
