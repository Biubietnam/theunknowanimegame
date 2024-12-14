using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200005B RID: 91
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideRefreshEndlessScNotify : IMessage<AetherDivideRefreshEndlessScNotify>, IMessage, IEquatable<AetherDivideRefreshEndlessScNotify>, IDeepCloneable<AetherDivideRefreshEndlessScNotify>, IBufferMessage
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000B841 File Offset: 0x00009A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideRefreshEndlessScNotify> Parser
		{
			get
			{
				return AetherDivideRefreshEndlessScNotify._parser;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0000B848 File Offset: 0x00009A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideRefreshEndlessScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000B85A File Offset: 0x00009A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideRefreshEndlessScNotify.Descriptor;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000B861 File Offset: 0x00009A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessScNotify()
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000B869 File Offset: 0x00009A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessScNotify(AetherDivideRefreshEndlessScNotify other) : this()
		{
			this.pHPCDGEMAGD_ = other.pHPCDGEMAGD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000B88E File Offset: 0x00009A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessScNotify Clone()
		{
			return new AetherDivideRefreshEndlessScNotify(this);
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000B896 File Offset: 0x00009A96
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0000B89E File Offset: 0x00009A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHPCDGEMAGD
		{
			get
			{
				return this.pHPCDGEMAGD_;
			}
			set
			{
				this.pHPCDGEMAGD_ = value;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000B8A7 File Offset: 0x00009AA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideRefreshEndlessScNotify);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000B8B5 File Offset: 0x00009AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideRefreshEndlessScNotify other)
		{
			return other != null && (other == this || (this.PHPCDGEMAGD == other.PHPCDGEMAGD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000B8E4 File Offset: 0x00009AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PHPCDGEMAGD != 0U)
			{
				num ^= this.PHPCDGEMAGD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000B923 File Offset: 0x00009B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000B92B File Offset: 0x00009B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000B934 File Offset: 0x00009B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PHPCDGEMAGD != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PHPCDGEMAGD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000B968 File Offset: 0x00009B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PHPCDGEMAGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHPCDGEMAGD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000B9A6 File Offset: 0x00009BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideRefreshEndlessScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PHPCDGEMAGD != 0U)
			{
				this.PHPCDGEMAGD = other.PHPCDGEMAGD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000B9D7 File Offset: 0x00009BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PHPCDGEMAGD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000167 RID: 359
		private static readonly MessageParser<AetherDivideRefreshEndlessScNotify> _parser = new MessageParser<AetherDivideRefreshEndlessScNotify>(() => new AetherDivideRefreshEndlessScNotify());

		// Token: 0x04000168 RID: 360
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000169 RID: 361
		public const int PHPCDGEMAGDFieldNumber = 8;

		// Token: 0x0400016A RID: 362
		private uint pHPCDGEMAGD_;
	}
}
