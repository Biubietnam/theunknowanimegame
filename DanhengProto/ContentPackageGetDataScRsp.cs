using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000329 RID: 809
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ContentPackageGetDataScRsp : IMessage<ContentPackageGetDataScRsp>, IMessage, IEquatable<ContentPackageGetDataScRsp>, IDeepCloneable<ContentPackageGetDataScRsp>, IBufferMessage
	{
		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x00066CF3 File Offset: 0x00064EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ContentPackageGetDataScRsp> Parser
		{
			get
			{
				return ContentPackageGetDataScRsp._parser;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x00066CFA File Offset: 0x00064EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ContentPackageGetDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x00066D0C File Offset: 0x00064F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentPackageGetDataScRsp.Descriptor;
			}
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00066D13 File Offset: 0x00064F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageGetDataScRsp()
		{
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00066D1C File Offset: 0x00064F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageGetDataScRsp(ContentPackageGetDataScRsp other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00066D68 File Offset: 0x00064F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageGetDataScRsp Clone()
		{
			return new ContentPackageGetDataScRsp(this);
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x00066D70 File Offset: 0x00064F70
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x00066D78 File Offset: 0x00064F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContentPackageData Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x00066D81 File Offset: 0x00064F81
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x00066D89 File Offset: 0x00064F89
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

		// Token: 0x0600244E RID: 9294 RVA: 0x00066D92 File Offset: 0x00064F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentPackageGetDataScRsp);
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00066DA0 File Offset: 0x00064FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContentPackageGetDataScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00066DF0 File Offset: 0x00064FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
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

		// Token: 0x06002451 RID: 9297 RVA: 0x00066E45 File Offset: 0x00065045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00066E4D File Offset: 0x0006504D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00066E58 File Offset: 0x00065058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Data);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00066EB4 File Offset: 0x000650B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
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

		// Token: 0x06002455 RID: 9301 RVA: 0x00066F0C File Offset: 0x0006510C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContentPackageGetDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new ContentPackageData();
				}
				this.Data.MergeFrom(other.Data);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00066F74 File Offset: 0x00065174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00066F80 File Offset: 0x00065180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 88U)
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
					if (this.data_ == null)
					{
						this.Data = new ContentPackageData();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x04000ED7 RID: 3799
		private static readonly MessageParser<ContentPackageGetDataScRsp> _parser = new MessageParser<ContentPackageGetDataScRsp>(() => new ContentPackageGetDataScRsp());

		// Token: 0x04000ED8 RID: 3800
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ED9 RID: 3801
		public const int DataFieldNumber = 4;

		// Token: 0x04000EDA RID: 3802
		private ContentPackageData data_;

		// Token: 0x04000EDB RID: 3803
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04000EDC RID: 3804
		private uint retcode_;
	}
}
