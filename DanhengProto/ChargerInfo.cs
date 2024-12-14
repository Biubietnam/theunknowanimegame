using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D7 RID: 471
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChargerInfo : IMessage<ChargerInfo>, IMessage, IEquatable<ChargerInfo>, IDeepCloneable<ChargerInfo>, IBufferMessage
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0003C86C File Offset: 0x0003AA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChargerInfo> Parser
		{
			get
			{
				return ChargerInfo._parser;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0003C873 File Offset: 0x0003AA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChargerInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0003C885 File Offset: 0x0003AA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChargerInfo.Descriptor;
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0003C88C File Offset: 0x0003AA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChargerInfo()
		{
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0003C894 File Offset: 0x0003AA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChargerInfo(ChargerInfo other) : this()
		{
			this.gMCFBLFAFFO_ = other.gMCFBLFAFFO_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0003C8C5 File Offset: 0x0003AAC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChargerInfo Clone()
		{
			return new ChargerInfo(this);
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0003C8CD File Offset: 0x0003AACD
		// (set) Token: 0x06001527 RID: 5415 RVA: 0x0003C8D5 File Offset: 0x0003AAD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GMCFBLFAFFO
		{
			get
			{
				return this.gMCFBLFAFFO_;
			}
			set
			{
				this.gMCFBLFAFFO_ = value;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0003C8DE File Offset: 0x0003AADE
		// (set) Token: 0x06001529 RID: 5417 RVA: 0x0003C8E6 File Offset: 0x0003AAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0003C8EF File Offset: 0x0003AAEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChargerInfo);
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0003C8FD File Offset: 0x0003AAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChargerInfo other)
		{
			return other != null && (other == this || (this.GMCFBLFAFFO == other.GMCFBLFAFFO && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0003C93C File Offset: 0x0003AB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GMCFBLFAFFO != 0U)
			{
				num ^= this.GMCFBLFAFFO.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0003C994 File Offset: 0x0003AB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0003C99C File Offset: 0x0003AB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GMCFBLFAFFO != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GMCFBLFAFFO);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0003CA04 File Offset: 0x0003AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GMCFBLFAFFO != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GMCFBLFAFFO);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0003CA5C File Offset: 0x0003AC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChargerInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GMCFBLFAFFO != 0U)
			{
				this.GMCFBLFAFFO = other.GMCFBLFAFFO;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0003CAAC File Offset: 0x0003ACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0003CAB8 File Offset: 0x0003ACB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GroupId = input.ReadUInt32();
					}
				}
				else
				{
					this.GMCFBLFAFFO = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040008D9 RID: 2265
		private static readonly MessageParser<ChargerInfo> _parser = new MessageParser<ChargerInfo>(() => new ChargerInfo());

		// Token: 0x040008DA RID: 2266
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008DB RID: 2267
		public const int GMCFBLFAFFOFieldNumber = 8;

		// Token: 0x040008DC RID: 2268
		private uint gMCFBLFAFFO_;

		// Token: 0x040008DD RID: 2269
		public const int GroupIdFieldNumber = 9;

		// Token: 0x040008DE RID: 2270
		private uint groupId_;
	}
}
