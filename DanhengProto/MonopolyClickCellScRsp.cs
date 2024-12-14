using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B17 RID: 2839
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyClickCellScRsp : IMessage<MonopolyClickCellScRsp>, IMessage, IEquatable<MonopolyClickCellScRsp>, IDeepCloneable<MonopolyClickCellScRsp>, IBufferMessage
	{
		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x06007DAC RID: 32172 RVA: 0x0014C929 File Offset: 0x0014AB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyClickCellScRsp> Parser
		{
			get
			{
				return MonopolyClickCellScRsp._parser;
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x06007DAD RID: 32173 RVA: 0x0014C930 File Offset: 0x0014AB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyClickCellScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x06007DAE RID: 32174 RVA: 0x0014C942 File Offset: 0x0014AB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyClickCellScRsp.Descriptor;
			}
		}

		// Token: 0x06007DAF RID: 32175 RVA: 0x0014C949 File Offset: 0x0014AB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickCellScRsp()
		{
		}

		// Token: 0x06007DB0 RID: 32176 RVA: 0x0014C951 File Offset: 0x0014AB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickCellScRsp(MonopolyClickCellScRsp other) : this()
		{
			this.cellId_ = other.cellId_;
			this.mapId_ = other.mapId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007DB1 RID: 32177 RVA: 0x0014C98E File Offset: 0x0014AB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyClickCellScRsp Clone()
		{
			return new MonopolyClickCellScRsp(this);
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x06007DB2 RID: 32178 RVA: 0x0014C996 File Offset: 0x0014AB96
		// (set) Token: 0x06007DB3 RID: 32179 RVA: 0x0014C99E File Offset: 0x0014AB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06007DB4 RID: 32180 RVA: 0x0014C9A7 File Offset: 0x0014ABA7
		// (set) Token: 0x06007DB5 RID: 32181 RVA: 0x0014C9AF File Offset: 0x0014ABAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x06007DB6 RID: 32182 RVA: 0x0014C9B8 File Offset: 0x0014ABB8
		// (set) Token: 0x06007DB7 RID: 32183 RVA: 0x0014C9C0 File Offset: 0x0014ABC0
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

		// Token: 0x06007DB8 RID: 32184 RVA: 0x0014C9C9 File Offset: 0x0014ABC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyClickCellScRsp);
		}

		// Token: 0x06007DB9 RID: 32185 RVA: 0x0014C9D8 File Offset: 0x0014ABD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyClickCellScRsp other)
		{
			return other != null && (other == this || (this.CellId == other.CellId && this.MapId == other.MapId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007DBA RID: 32186 RVA: 0x0014CA34 File Offset: 0x0014AC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this.MapId != 0U)
			{
				num ^= this.MapId.GetHashCode();
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

		// Token: 0x06007DBB RID: 32187 RVA: 0x0014CAA5 File Offset: 0x0014ACA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007DBC RID: 32188 RVA: 0x0014CAAD File Offset: 0x0014ACAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007DBD RID: 32189 RVA: 0x0014CAB8 File Offset: 0x0014ACB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CellId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CellId);
			}
			if (this.MapId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007DBE RID: 32190 RVA: 0x0014CB30 File Offset: 0x0014AD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this.MapId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MapId);
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

		// Token: 0x06007DBF RID: 32191 RVA: 0x0014CBA0 File Offset: 0x0014ADA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyClickCellScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			if (other.MapId != 0U)
			{
				this.MapId = other.MapId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007DC0 RID: 32192 RVA: 0x0014CC04 File Offset: 0x0014AE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007DC1 RID: 32193 RVA: 0x0014CC10 File Offset: 0x0014AE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MapId = input.ReadUInt32();
						}
					}
					else
					{
						this.CellId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003043 RID: 12355
		private static readonly MessageParser<MonopolyClickCellScRsp> _parser = new MessageParser<MonopolyClickCellScRsp>(() => new MonopolyClickCellScRsp());

		// Token: 0x04003044 RID: 12356
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003045 RID: 12357
		public const int CellIdFieldNumber = 3;

		// Token: 0x04003046 RID: 12358
		private uint cellId_;

		// Token: 0x04003047 RID: 12359
		public const int MapIdFieldNumber = 14;

		// Token: 0x04003048 RID: 12360
		private uint mapId_;

		// Token: 0x04003049 RID: 12361
		public const int RetcodeFieldNumber = 2;

		// Token: 0x0400304A RID: 12362
		private uint retcode_;
	}
}
