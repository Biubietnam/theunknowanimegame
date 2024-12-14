using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200001F RID: 31
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptMissionEventScRsp : IMessage<AcceptMissionEventScRsp>, IMessage, IEquatable<AcceptMissionEventScRsp>, IDeepCloneable<AcceptMissionEventScRsp>, IBufferMessage
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000470D File Offset: 0x0000290D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptMissionEventScRsp> Parser
		{
			get
			{
				return AcceptMissionEventScRsp._parser;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00004714 File Offset: 0x00002914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptMissionEventScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00004726 File Offset: 0x00002926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptMissionEventScRsp.Descriptor;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000472D File Offset: 0x0000292D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMissionEventScRsp()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00004738 File Offset: 0x00002938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMissionEventScRsp(AcceptMissionEventScRsp other) : this()
		{
			this.iAPIOFPLDEK_ = ((other.iAPIOFPLDEK_ != null) ? other.iAPIOFPLDEK_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004784 File Offset: 0x00002984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMissionEventScRsp Clone()
		{
			return new AcceptMissionEventScRsp(this);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000478C File Offset: 0x0000298C
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00004794 File Offset: 0x00002994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Mission IAPIOFPLDEK
		{
			get
			{
				return this.iAPIOFPLDEK_;
			}
			set
			{
				this.iAPIOFPLDEK_ = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000479D File Offset: 0x0000299D
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000047A5 File Offset: 0x000029A5
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

		// Token: 0x0600011C RID: 284 RVA: 0x000047AE File Offset: 0x000029AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptMissionEventScRsp);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000047BC File Offset: 0x000029BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptMissionEventScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.IAPIOFPLDEK, other.IAPIOFPLDEK) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000480C File Offset: 0x00002A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.iAPIOFPLDEK_ != null)
			{
				num ^= this.IAPIOFPLDEK.GetHashCode();
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

		// Token: 0x0600011F RID: 287 RVA: 0x00004861 File Offset: 0x00002A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004869 File Offset: 0x00002A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00004874 File Offset: 0x00002A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.iAPIOFPLDEK_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.IAPIOFPLDEK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000048D0 File Offset: 0x00002AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.iAPIOFPLDEK_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IAPIOFPLDEK);
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

		// Token: 0x06000123 RID: 291 RVA: 0x00004928 File Offset: 0x00002B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptMissionEventScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.iAPIOFPLDEK_ != null)
			{
				if (this.iAPIOFPLDEK_ == null)
				{
					this.IAPIOFPLDEK = new Mission();
				}
				this.IAPIOFPLDEK.MergeFrom(other.IAPIOFPLDEK);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00004990 File Offset: 0x00002B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000499C File Offset: 0x00002B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.iAPIOFPLDEK_ == null)
						{
							this.IAPIOFPLDEK = new Mission();
						}
						input.ReadMessage(this.IAPIOFPLDEK);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400005C RID: 92
		private static readonly MessageParser<AcceptMissionEventScRsp> _parser = new MessageParser<AcceptMissionEventScRsp>(() => new AcceptMissionEventScRsp());

		// Token: 0x0400005D RID: 93
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400005E RID: 94
		public const int IAPIOFPLDEKFieldNumber = 15;

		// Token: 0x0400005F RID: 95
		private Mission iAPIOFPLDEK_;

		// Token: 0x04000060 RID: 96
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04000061 RID: 97
		private uint retcode_;
	}
}
