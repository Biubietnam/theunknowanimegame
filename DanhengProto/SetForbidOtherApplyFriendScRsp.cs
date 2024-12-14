using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010EF RID: 4335
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetForbidOtherApplyFriendScRsp : IMessage<SetForbidOtherApplyFriendScRsp>, IMessage, IEquatable<SetForbidOtherApplyFriendScRsp>, IDeepCloneable<SetForbidOtherApplyFriendScRsp>, IBufferMessage
	{
		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0600C143 RID: 49475 RVA: 0x0020789D File Offset: 0x00205A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetForbidOtherApplyFriendScRsp> Parser
		{
			get
			{
				return SetForbidOtherApplyFriendScRsp._parser;
			}
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600C144 RID: 49476 RVA: 0x002078A4 File Offset: 0x00205AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetForbidOtherApplyFriendScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600C145 RID: 49477 RVA: 0x002078B6 File Offset: 0x00205AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetForbidOtherApplyFriendScRsp.Descriptor;
			}
		}

		// Token: 0x0600C146 RID: 49478 RVA: 0x002078BD File Offset: 0x00205ABD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetForbidOtherApplyFriendScRsp()
		{
		}

		// Token: 0x0600C147 RID: 49479 RVA: 0x002078C5 File Offset: 0x00205AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetForbidOtherApplyFriendScRsp(SetForbidOtherApplyFriendScRsp other) : this()
		{
			this.nDBCIOELLJL_ = other.nDBCIOELLJL_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C148 RID: 49480 RVA: 0x002078F6 File Offset: 0x00205AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetForbidOtherApplyFriendScRsp Clone()
		{
			return new SetForbidOtherApplyFriendScRsp(this);
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600C149 RID: 49481 RVA: 0x002078FE File Offset: 0x00205AFE
		// (set) Token: 0x0600C14A RID: 49482 RVA: 0x00207906 File Offset: 0x00205B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NDBCIOELLJL
		{
			get
			{
				return this.nDBCIOELLJL_;
			}
			set
			{
				this.nDBCIOELLJL_ = value;
			}
		}

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600C14B RID: 49483 RVA: 0x0020790F File Offset: 0x00205B0F
		// (set) Token: 0x0600C14C RID: 49484 RVA: 0x00207917 File Offset: 0x00205B17
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

		// Token: 0x0600C14D RID: 49485 RVA: 0x00207920 File Offset: 0x00205B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetForbidOtherApplyFriendScRsp);
		}

		// Token: 0x0600C14E RID: 49486 RVA: 0x0020792E File Offset: 0x00205B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetForbidOtherApplyFriendScRsp other)
		{
			return other != null && (other == this || (this.NDBCIOELLJL == other.NDBCIOELLJL && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C14F RID: 49487 RVA: 0x0020796C File Offset: 0x00205B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NDBCIOELLJL)
			{
				num ^= this.NDBCIOELLJL.GetHashCode();
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

		// Token: 0x0600C150 RID: 49488 RVA: 0x002079C4 File Offset: 0x00205BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C151 RID: 49489 RVA: 0x002079CC File Offset: 0x00205BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C152 RID: 49490 RVA: 0x002079D8 File Offset: 0x00205BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.NDBCIOELLJL)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.NDBCIOELLJL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x00207A30 File Offset: 0x00205C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NDBCIOELLJL)
			{
				num += 2;
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

		// Token: 0x0600C154 RID: 49492 RVA: 0x00207A7C File Offset: 0x00205C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetForbidOtherApplyFriendScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NDBCIOELLJL)
			{
				this.NDBCIOELLJL = other.NDBCIOELLJL;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C155 RID: 49493 RVA: 0x00207ACC File Offset: 0x00205CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C156 RID: 49494 RVA: 0x00207AD8 File Offset: 0x00205CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NDBCIOELLJL = input.ReadBool();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E46 RID: 20038
		private static readonly MessageParser<SetForbidOtherApplyFriendScRsp> _parser = new MessageParser<SetForbidOtherApplyFriendScRsp>(() => new SetForbidOtherApplyFriendScRsp());

		// Token: 0x04004E47 RID: 20039
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E48 RID: 20040
		public const int NDBCIOELLJLFieldNumber = 15;

		// Token: 0x04004E49 RID: 20041
		private bool nDBCIOELLJL_;

		// Token: 0x04004E4A RID: 20042
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04004E4B RID: 20043
		private uint retcode_;
	}
}
