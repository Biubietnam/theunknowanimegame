using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200038D RID: 909
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DestroyItemScRsp : IMessage<DestroyItemScRsp>, IMessage, IEquatable<DestroyItemScRsp>, IDeepCloneable<DestroyItemScRsp>, IBufferMessage
	{
		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x00070644 File Offset: 0x0006E844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DestroyItemScRsp> Parser
		{
			get
			{
				return DestroyItemScRsp._parser;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x0007064B File Offset: 0x0006E84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DestroyItemScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x0007065D File Offset: 0x0006E85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DestroyItemScRsp.Descriptor;
			}
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x00070664 File Offset: 0x0006E864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyItemScRsp()
		{
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0007066C File Offset: 0x0006E86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyItemScRsp(DestroyItemScRsp other) : this()
		{
			this.curItemCount_ = other.curItemCount_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0007069D File Offset: 0x0006E89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DestroyItemScRsp Clone()
		{
			return new DestroyItemScRsp(this);
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x000706A5 File Offset: 0x0006E8A5
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x000706AD File Offset: 0x0006E8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurItemCount
		{
			get
			{
				return this.curItemCount_;
			}
			set
			{
				this.curItemCount_ = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x000706B6 File Offset: 0x0006E8B6
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x000706BE File Offset: 0x0006E8BE
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

		// Token: 0x06002875 RID: 10357 RVA: 0x000706C7 File Offset: 0x0006E8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DestroyItemScRsp);
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x000706D5 File Offset: 0x0006E8D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DestroyItemScRsp other)
		{
			return other != null && (other == this || (this.CurItemCount == other.CurItemCount && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00070714 File Offset: 0x0006E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurItemCount != 0U)
			{
				num ^= this.CurItemCount.GetHashCode();
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

		// Token: 0x06002878 RID: 10360 RVA: 0x0007076C File Offset: 0x0006E96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00070774 File Offset: 0x0006E974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x00070780 File Offset: 0x0006E980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CurItemCount != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CurItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x000707D8 File Offset: 0x0006E9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurItemCount != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurItemCount);
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

		// Token: 0x0600287C RID: 10364 RVA: 0x00070830 File Offset: 0x0006EA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DestroyItemScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurItemCount != 0U)
			{
				this.CurItemCount = other.CurItemCount;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x00070880 File Offset: 0x0006EA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0007088C File Offset: 0x0006EA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurItemCount = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400103B RID: 4155
		private static readonly MessageParser<DestroyItemScRsp> _parser = new MessageParser<DestroyItemScRsp>(() => new DestroyItemScRsp());

		// Token: 0x0400103C RID: 4156
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400103D RID: 4157
		public const int CurItemCountFieldNumber = 4;

		// Token: 0x0400103E RID: 4158
		private uint curItemCount_;

		// Token: 0x0400103F RID: 4159
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04001040 RID: 4160
		private uint retcode_;
	}
}
