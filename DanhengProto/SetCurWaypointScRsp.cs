using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010E7 RID: 4327
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetCurWaypointScRsp : IMessage<SetCurWaypointScRsp>, IMessage, IEquatable<SetCurWaypointScRsp>, IDeepCloneable<SetCurWaypointScRsp>, IBufferMessage
	{
		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0600C0ED RID: 49389 RVA: 0x00206D18 File Offset: 0x00204F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetCurWaypointScRsp> Parser
		{
			get
			{
				return SetCurWaypointScRsp._parser;
			}
		}

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0600C0EE RID: 49390 RVA: 0x00206D1F File Offset: 0x00204F1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetCurWaypointScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0600C0EF RID: 49391 RVA: 0x00206D31 File Offset: 0x00204F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetCurWaypointScRsp.Descriptor;
			}
		}

		// Token: 0x0600C0F0 RID: 49392 RVA: 0x00206D38 File Offset: 0x00204F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurWaypointScRsp()
		{
		}

		// Token: 0x0600C0F1 RID: 49393 RVA: 0x00206D40 File Offset: 0x00204F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurWaypointScRsp(SetCurWaypointScRsp other) : this()
		{
			this.fALDHGHICGI_ = other.fALDHGHICGI_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0F2 RID: 49394 RVA: 0x00206D71 File Offset: 0x00204F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetCurWaypointScRsp Clone()
		{
			return new SetCurWaypointScRsp(this);
		}

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0600C0F3 RID: 49395 RVA: 0x00206D79 File Offset: 0x00204F79
		// (set) Token: 0x0600C0F4 RID: 49396 RVA: 0x00206D81 File Offset: 0x00204F81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FALDHGHICGI
		{
			get
			{
				return this.fALDHGHICGI_;
			}
			set
			{
				this.fALDHGHICGI_ = value;
			}
		}

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0600C0F5 RID: 49397 RVA: 0x00206D8A File Offset: 0x00204F8A
		// (set) Token: 0x0600C0F6 RID: 49398 RVA: 0x00206D92 File Offset: 0x00204F92
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

		// Token: 0x0600C0F7 RID: 49399 RVA: 0x00206D9B File Offset: 0x00204F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetCurWaypointScRsp);
		}

		// Token: 0x0600C0F8 RID: 49400 RVA: 0x00206DA9 File Offset: 0x00204FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetCurWaypointScRsp other)
		{
			return other != null && (other == this || (this.FALDHGHICGI == other.FALDHGHICGI && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0F9 RID: 49401 RVA: 0x00206DE8 File Offset: 0x00204FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FALDHGHICGI != 0U)
			{
				num ^= this.FALDHGHICGI.GetHashCode();
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

		// Token: 0x0600C0FA RID: 49402 RVA: 0x00206E40 File Offset: 0x00205040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C0FB RID: 49403 RVA: 0x00206E48 File Offset: 0x00205048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0FC RID: 49404 RVA: 0x00206E54 File Offset: 0x00205054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FALDHGHICGI != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.FALDHGHICGI);
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

		// Token: 0x0600C0FD RID: 49405 RVA: 0x00206EB0 File Offset: 0x002050B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FALDHGHICGI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FALDHGHICGI);
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

		// Token: 0x0600C0FE RID: 49406 RVA: 0x00206F08 File Offset: 0x00205108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetCurWaypointScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FALDHGHICGI != 0U)
			{
				this.FALDHGHICGI = other.FALDHGHICGI;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0FF RID: 49407 RVA: 0x00206F58 File Offset: 0x00205158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C100 RID: 49408 RVA: 0x00206F64 File Offset: 0x00205164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
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
					this.FALDHGHICGI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E2C RID: 20012
		private static readonly MessageParser<SetCurWaypointScRsp> _parser = new MessageParser<SetCurWaypointScRsp>(() => new SetCurWaypointScRsp());

		// Token: 0x04004E2D RID: 20013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E2E RID: 20014
		public const int FALDHGHICGIFieldNumber = 5;

		// Token: 0x04004E2F RID: 20015
		private uint fALDHGHICGI_;

		// Token: 0x04004E30 RID: 20016
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04004E31 RID: 20017
		private uint retcode_;
	}
}
